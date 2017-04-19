using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO.Ports;
using Un4seen.Bass;
using Un4seen.BassWasapi;
using Un4seen.Bass.Misc;

namespace CLC
{
    public class Controller
    {
        public enum Mode {ON, OFF, LEVELS, BEAT, FADE};
        public static Mode currentMode = Mode.ON;
        private int soundDevice = 0;
        public int intensity=255, sensitivity=450, speed=3;
        private static byte[] sendData = new byte[1024];

        private bool init = false;
        public static SerialPort port = new SerialPort();
        private static WASAPIPROC _process;
        private static Visuals v = new Visuals();
        public Controller()
        {
            Un4seen.Bass.BassNet.Registration("cschlisner@gmail.com", "2X2283720152222");
            AppDomain.CurrentDomain.ProcessExit += new EventHandler(OnProcessExit);
            Bass.BASS_SetConfig(BASSConfig.BASS_CONFIG_UPDATETHREADS, false);
            _process = new WASAPIPROC(Process);
            initDeviceList();
        }

        

        private int Process(IntPtr buffer, int length, IntPtr user)
        {
            return length;
        }

        public void Start()
        {
            SwitchMode(currentMode);
        }

        public string[] deviceList { get; private set; }

        // should only run once
        public void initDeviceList()
        {
            List<string> res = new List<string>();
            for (int i = 0; i < BassWasapi.BASS_WASAPI_GetDeviceCount(); i++)
            {
                var device = BassWasapi.BASS_WASAPI_GetDeviceInfo(i);
                if (device.IsEnabled && device.IsLoopback)
                {
                    res.Add(String.Format("{0} - {1}", i, device.name));
                }
            }
            deviceList = res.ToArray();
        }

        public void deviceInit(int device)
        {
            bool result = Bass.BASS_Init(0, 44100, BASSInit.BASS_DEVICE_DEFAULT, IntPtr.Zero);
            if (!result) throw new Exception("Init Error");
            BassWasapi.BASS_WASAPI_Init(device, 0, 0, BASSWASAPIInit.BASS_WASAPI_BUFFER, 1f, 0.05f, _process, IntPtr.Zero);
            init = true;
            soundDevice = device;
        }
        public void deviceFree()
        {
            BassWasapi.BASS_WASAPI_Free();
            Bass.BASS_Free();
        }

        public void SwitchMode(Mode m)
        {
            Properties.Settings.Default["ModeDefault"] = m.ToString();
            Properties.Settings.Default.Save();
            switch (m)
            {
                case Mode.ON:
                    ON();
                    break; 
                case Mode.OFF:
                    OFF();
                    break; 
                case Mode.LEVELS:
                    MonitorLevels();
                    break;
                case Mode.BEAT:
                    MonitorBeat();
                    break;
                case Mode.FADE:
                    Fade();
                    break;
            }
        }

        private void OFF()
        {
            Send((byte)0);
            while (currentMode == Mode.OFF)
            { }
            SwitchMode(currentMode);
        }

        private void ON()
        {
            while (currentMode == Mode.ON)
            { Send((byte)intensity); }
            SwitchMode(currentMode);
        }

        private void Fade()
        {
            int i = sendData[0];
            int s = speed;
            while (currentMode == Mode.FADE)
            {
                if (i >= 255 || i <= 0)
                    speed = -speed;
                i += (speed<0)?((i+speed<0)?(0-i):speed):((speed+i>255)?255-i:speed);
                Send((byte)i);
                Thread.Sleep(30);
            }
            SwitchMode(currentMode);
        }

        private void MonitorBeat()
        {
            deviceFree();
            deviceInit(soundDevice);
            float[] buffer = new float[1024];
            BassWasapi.BASS_WASAPI_Start();
            while (currentMode == Mode.BEAT)
            {
                BassWasapi.BASS_WASAPI_GetData(buffer, (int)BASSData.BASS_DATA_FFT2048);
                Byte[] data = fft(buffer);
                if (data[0] + data[1] + data[2] > sensitivity)
                    Send((byte)intensity);
                else Send((byte)0);
            }
            BassWasapi.BASS_WASAPI_Stop(true);
            deviceFree();
            SwitchMode(currentMode);
        }

        private void MonitorLevels()
        {
            deviceFree();
            deviceInit(soundDevice);
            float[] buffer = new float[1024];
            BassWasapi.BASS_WASAPI_Start();
            while (currentMode == Mode.LEVELS)
            {
                BassWasapi.BASS_WASAPI_GetData(buffer, (int)BASSData.BASS_DATA_FFT2048);
                Byte[] data = fft(buffer);
                port.Write(data, 0, 1);
            }
            BassWasapi.BASS_WASAPI_Stop(false);
            deviceFree();
            SwitchMode(currentMode);
        }
        private byte[] fft(float[] data)
        {
            int bars = 16;
            List<byte> res = new List<byte>();
            int b0 = 0;
            for (int x = 0, y; x < bars; x++)
            {
                float peak = 0;
                int b1 = (int)Math.Pow(2, x * 10.0 / (bars - 1));
                if (b1 > data.Length - 1) b1 = data.Length - 1;
                if (b1 <= b0) b1 = b0 + 1;
                for (; b0 < b1; b0++)
                {
                    if (peak < data[1 + b0]) peak = data[1 + b0];
                }
                y = (int)(Math.Sqrt(peak) * 3 * 255 - 4);
                if (y > 255) y = 255;
                if (y < 0) y = 0;
                res.Add((byte)y);
            }
            return res.ToArray();
        }

        private void Send(byte b)
        {
            sendData[0] = b;
            try
            {
                port.Write(sendData, 0, 1);

            }
            catch (Exception e)
            {
                // nah
            }
        }

        private void OnProcessExit(object sender, EventArgs e)
        {
            Send((byte)255);
            port.Close();
            deviceFree();
        }
    }
}
