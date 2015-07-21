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
    public partial class Form1 : Form
    {
        Controller controller = new Controller();
        Thread workerThread;
        SettingsForm settingsForm;
        public Form1()
        {
            InitializeComponent();
            Controller.port = new SerialPort((string)Properties.Settings.Default["COMPortDefault"], 9600);
            switch ((string)Properties.Settings.Default["ModeDefault"])
            {
                case "ON":
                    Controller.currentMode = Controller.Mode.ON;
                    break;
                case "OFF":
                    Controller.currentMode = Controller.Mode.OFF;
                    break;
                case "LEVELS":
                    Controller.currentMode = Controller.Mode.LEVELS;
                    break;
                case "BEAT":
                    Controller.currentMode = Controller.Mode.BEAT;
                    break;
                case "FADE":
                    Controller.currentMode = Controller.Mode.FADE;
                    break;
            }


            deviceCB.Items.AddRange(controller.getDeviceList());
            int k = (int)Properties.Settings.Default["DeviceDefault"];
            deviceCB.SelectedIndex = (k >= deviceCB.Items.Count) ? 0 : k;
            Controller.port.Open();

            controller.intensity = (int)Properties.Settings.Default["IntDefault"];
            controller.sensitivity = (int)Properties.Settings.Default["SenDefault"];
            controller.speed = (int)Properties.Settings.Default["SpeDefault"];
            settingsForm = new SettingsForm(controller, workerThread);
            workerThread = new Thread(controller.Start);
            workerThread.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Hide();
            //this.SetDesktopLocation(Screen.FromControl(this).Bounds.Width - this.Bounds.Width, Screen.PrimaryScreen.WorkingArea.Height - this.Bounds.Height);
            
        }
        private void Form1_Shown(object sender, EventArgs e)
        {
           //this.WindowState = FormWindowState.Minimized;
           this.Hide();
        }
       
       
        private void enableAll()
        {
            foreach (ToolStripItem i in contextMenuStrip1.Items)
                i.Visible = true;
        }
        private void toolStripOn_Click(object sender, EventArgs e)
        {
            Controller.currentMode = Controller.Mode.ON;
        }

        private void toolStripOff_Click(object sender, EventArgs e)
        {
            Controller.currentMode = Controller.Mode.OFF;
        }

        private void toolStripBass_Click(object sender, EventArgs e)
        {
            Controller.currentMode = Controller.Mode.LEVELS;
        }

        private void toolStripBeat_Click(object sender, EventArgs e)
        {
            Controller.currentMode = Controller.Mode.BEAT;
        }

        private void toolStripFade_Click(object sender, EventArgs e)
        {
            Controller.currentMode = Controller.Mode.FADE;
        }

        private void toolStripSettings_Click(object sender, EventArgs e)
        {
            if (settingsForm.IsDisposed)
                settingsForm = new SettingsForm(controller, workerThread);
            settingsForm.Show();
            settingsForm.BringToFront();
        }

        private void toolStripExit_Click(object sender, EventArgs e)
        {
            workerThread.Abort();
            this.Close();
        }

        private void Form1_Move(object sender, EventArgs e)
        {
        }

        private void deviceCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            controller.deviceFree();
            controller.deviceInit(Convert.ToInt32(deviceCB.SelectedItem.ToString().Remove(2)));
            Properties.Settings.Default["DeviceDefault"] = deviceCB.SelectedIndex;
            Properties.Settings.Default.Save();
        }

        private void contextMenuStrip1_Opened(object sender, EventArgs e)
        {
            enableAll();
            switch (Controller.currentMode)
            {
                case Controller.Mode.ON:
                    toolStripOn.Visible = false;
                    break;
                case Controller.Mode.OFF:
                    toolStripOff.Visible = false;
                    break;
                case Controller.Mode.BEAT:
                    toolStripBeat.Visible = false;
                    break;
                case Controller.Mode.LEVELS:
                    toolStripBass.Visible = false;
                    break;
                case Controller.Mode.FADE:
                    toolStripFade.Visible = false;
                    break;
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
