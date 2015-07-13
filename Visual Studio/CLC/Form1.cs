using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace CLC
{
    public partial class Form1 : Form
    {
        Controller controller = new Controller();
        Thread workerThread;
        public Form1()
        {
            InitializeComponent();
            sensitivityTB.Enabled = false;
            speedTB.Enabled = false;
            workerThread = new Thread(controller.Start);
            workerThread.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.SetDesktopLocation(Screen.FromControl(this).Bounds.Width - 355, Screen.FromControl(this).Bounds.Height - 279);

        }
        private void Form1_Shown(object sender, EventArgs e)
        {
           //this.WindowState = FormWindowState.Minimized;
           this.Hide();
        }
        private void DisableTrackbars()
        {
            IntensityTB.Enabled = false;
            sensitivityTB.Enabled = false;
            speedTB.Enabled = false;
        }

        //ON
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            controller.currentMode = Controller.Mode.ON;
            DisableTrackbars();
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
            IntensityTB.Enabled = true;
            sensitivityTB.Enabled = true;
        }
        //FADE
        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            controller.currentMode = Controller.Mode.FADE;
            DisableTrackbars();
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
            if (MessageBox.Show("This will close down the whole application. Confirm?", "Close Application", MessageBoxButtons.YesNo) != DialogResult.Yes)
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
            this.Close();
        }

        private void Form1_Move(object sender, EventArgs e)
        {
        }
    }
}
