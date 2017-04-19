using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.IO.Ports;

namespace CLC
{
    public partial class SettingsForm : Form
    {
        Controller controller;
        Thread workerThread;
        public SettingsForm(Controller c, Thread t)
        {
            InitializeComponent();

            this.SetDesktopLocation(Screen.FromControl(this).Bounds.Width - this.Bounds.Width, Screen.PrimaryScreen.WorkingArea.Height - this.Bounds.Height);
            this.Show();
            this.BringToFront();

            controller = c;
            workerThread = t;

            sensitivityTB.Enabled = false;
            speedTB.Enabled = false;

            // Initialize COM Port dropdown
            string[] ports = SerialPort.GetPortNames();
            COMPortCB.Items.AddRange(ports);            
            COMPortCB.SelectedItem = COMPortCB.Items[COMPortCB.Items.IndexOf(Controller.port.PortName)];

            IntensityTB.Value = controller.intensity;
            sensitivityTB.Value = controller.sensitivity;
            speedTB.Value = Math.Abs(controller.speed);


            // Initialize Device List dropdown (takes the most time, so done after drawing)
            deviceCB.Items.AddRange(controller.deviceList);
            int k = (int)Properties.Settings.Default["DeviceDefault"];
            deviceCB.SelectedIndex = (k >= deviceCB.Items.Count) ? 0 : k;
            
        }

        private void SettingsForm_Shown(object sender, EventArgs e)
        {
            updateModeSelect();
        }

        public void updateModeSelect()
        {
            // Initialize buttons and levels
            switch (Controller.currentMode)
            {
                case Controller.Mode.ON:
                    ON.Checked = true;
                    break;
                case Controller.Mode.OFF:
                    OFF.Checked = true;
                    break;
                case Controller.Mode.BEAT:
                    BEAT.Checked = true;
                    break;
                case Controller.Mode.LEVELS:
                    LEVELS.Checked = true;
                    break;
                case Controller.Mode.FADE:
                    FADE.Checked = true;
                    break;
            }
        }

        private void DisableTrackbars()
        {
            label1.Enabled = false;
            label2.Enabled = false;
            label3.Enabled = false;
            IntensityTB.Enabled = false;
            sensitivityTB.Enabled = false;
            speedTB.Enabled = false;
        }

        //ON
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Controller.currentMode = Controller.Mode.ON;
            DisableTrackbars();
            label1.Enabled = true;
            IntensityTB.Enabled = true;
        }
        //OFF
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Controller.currentMode = Controller.Mode.OFF;
            DisableTrackbars();
        }
        //LEVELS
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Controller.currentMode = Controller.Mode.LEVELS;
            DisableTrackbars();
        }
        //BEAT
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            Controller.currentMode = Controller.Mode.BEAT;
            DisableTrackbars();
            label1.Enabled = true;
            IntensityTB.Enabled = true;
            label2.Enabled = true;
            sensitivityTB.Enabled = true;
        }
        //FADE
        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            Controller.currentMode = Controller.Mode.FADE;
            DisableTrackbars();
            label3.Enabled = true;
            speedTB.Enabled = true;
        }

        private void IntensityTB_Scroll(object sender, EventArgs e)
        {
            controller.intensity = IntensityTB.Value;
        }

        private void speedTB_Scroll(object sender, EventArgs e)
        {
            controller.speed = speedTB.Value;
        }

        private void sensitivityTB_Scroll(object sender, EventArgs e)
        {
            controller.sensitivity = 1000 - sensitivityTB.Value;
        }
        
        private void COMPortCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (workerThread != null) workerThread.Suspend();
            if (Controller.port.IsOpen) Controller.port.Close();
            Controller.port = new SerialPort(COMPortCB.SelectedItem.ToString(), 9600);
            Controller.port.Open();
            if (workerThread != null) workerThread.Resume();
            Properties.Settings.Default["COMPortDefault"] = COMPortCB.SelectedItem.ToString();
            Properties.Settings.Default.Save();
        }

        private void deviceCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            controller.deviceFree();
            controller.deviceInit(Convert.ToInt32(deviceCB.SelectedItem.ToString().Remove(2)));
            if (Controller.currentMode == Controller.Mode.BEAT)
            {
                OFF.Checked = true;
                BEAT.Checked = true;
            }
            else if (Controller.currentMode == Controller.Mode.LEVELS)
            {
                OFF.Checked = true;
                LEVELS.Checked = true;
            }
            Properties.Settings.Default["DeviceDefault"] = deviceCB.SelectedIndex;
            Properties.Settings.Default.Save();
        }

        private void sensitivityTB_MouseUp(object sender, MouseEventArgs e)
        {
            Properties.Settings.Default["SenDefault"] = sensitivityTB.Value;
            Properties.Settings.Default.Save();
        }

        private void IntensityTB_MouseUp(object sender, MouseEventArgs e)
        {
            Properties.Settings.Default["IntDefault"] = IntensityTB.Value;
            Properties.Settings.Default.Save();
        }

        private void speedTB_MouseUp(object sender, MouseEventArgs e)
        {
            Properties.Settings.Default["SpeDefault"] = speedTB.Value;
            Properties.Settings.Default.Save();
        }        
    }
}
