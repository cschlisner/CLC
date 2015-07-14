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
        bool exitButton = false;
        public Form1()
        {
            InitializeComponent();
            sensitivityTB.Enabled = false;
            speedTB.Enabled = false;

            // Initialize COM Port dropdown
            string[] ports = SerialPort.GetPortNames();
            COMPortCB.Items.AddRange(ports);
            Controller.port = new SerialPort((string)Properties.Settings.Default["COMPortDefault"], 9600);
            COMPortCB.SelectedItem = COMPortCB.Items[COMPortCB.Items.IndexOf(Controller.port.PortName)];

            //Initialize Device List dropdown
            deviceCB.Items.AddRange(controller.getDeviceList());
            deviceCB.SelectedIndex = (int)Properties.Settings.Default["DeviceDefault"];


            workerThread = new Thread(controller.Start);
            workerThread.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.SetDesktopLocation(Screen.FromControl(this).Bounds.Width - this.Bounds.Width, Screen.PrimaryScreen.WorkingArea.Height - this.Bounds.Height);
            
        }
        private void Form1_Shown(object sender, EventArgs e)
        {
           //this.WindowState = FormWindowState.Minimized;
           this.Hide();
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
            controller.currentMode = Controller.Mode.ON;
            DisableTrackbars();
            label1.Enabled = true;
            IntensityTB.Enabled = true;
        }
        //OFF
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            controller.currentMode = Controller.Mode.OFF;
            DisableTrackbars();
        }
        //LEVELS
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            controller.currentMode = Controller.Mode.LEVELS;
            DisableTrackbars();
        }
        //BEAT
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            controller.currentMode = Controller.Mode.BEAT;
            DisableTrackbars();
            label1.Enabled = true;
            IntensityTB.Enabled = true;
            label2.Enabled = true;
            sensitivityTB.Enabled = true;
        }
        //FADE
        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            controller.currentMode = Controller.Mode.FADE;
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
            controller.sensitivity = 1000-sensitivityTB.Value;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (!exitButton && MessageBox.Show("Exit app? \n(To hide the settings dialogue, press minimize)", "Close Application", MessageBoxButtons.YesNo) != DialogResult.Yes)
            {
                e.Cancel = true;
            } 
            else workerThread.Abort();
            
        }

        private void notifyIcon1_Click(object sender, EventArgs e)
        {
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
        }

        private void Form1_Resize_1(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
                Hide();
        }

        private void enableAll()
        {
            foreach (ToolStripItem i in contextMenuStrip1.Items)
                i.Visible = true;
        }
        private void toolStripOn_Click(object sender, EventArgs e)
        {
            enableAll();
            toolStripOn.Visible = false;
            ON.Checked = true;
        }

        private void toolStripOff_Click(object sender, EventArgs e)
        {
            enableAll();
            toolStripOff.Visible = false;
            OFF.Checked = true;
        }

        private void toolStripBass_Click(object sender, EventArgs e)
        {
            enableAll();
            toolStripBass.Visible = false;
            LEVELS.Checked = true;
        }

        private void toolStripBeat_Click(object sender, EventArgs e)
        {
            enableAll();
            toolStripBeat.Visible = false;
            BEAT.Checked = true;
        }

        private void toolStripFade_Click(object sender, EventArgs e)
        {
            enableAll();
            toolStripFade.Visible = false;
            FADE.Checked = true;
        }

        private void toolStripSettings_Click(object sender, EventArgs e)
        {
            Show();
            this.BringToFront();
            this.WindowState = FormWindowState.Normal;
        }

        private void toolStripExit_Click(object sender, EventArgs e)
        {
            exitButton = true;
            this.Close();
        }

        private void Form1_Move(object sender, EventArgs e)
        {
        }

        private void COMPortCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (workerThread!=null) workerThread.Suspend();
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
            if (controller.currentMode == Controller.Mode.BEAT)
            {
                OFF.Checked = true;
                BEAT.Checked = true;
            }
            else if (controller.currentMode == Controller.Mode.LEVELS)
            {
                OFF.Checked = true;
                LEVELS.Checked = true;
            }
            Properties.Settings.Default["DeviceDefault"] = deviceCB.SelectedIndex;
            Properties.Settings.Default.Save();
        }
    }
}
