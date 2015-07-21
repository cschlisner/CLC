namespace CLC
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.deviceCB = new System.Windows.Forms.ComboBox();
            this.COMPortCB = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FADE = new System.Windows.Forms.RadioButton();
            this.BEAT = new System.Windows.Forms.RadioButton();
            this.LEVELS = new System.Windows.Forms.RadioButton();
            this.OFF = new System.Windows.Forms.RadioButton();
            this.ON = new System.Windows.Forms.RadioButton();
            this.speedTB = new System.Windows.Forms.TrackBar();
            this.IntensityTB = new System.Windows.Forms.TrackBar();
            this.sensitivityTB = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.speedTB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IntensityTB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sensitivityTB)).BeginInit();
            this.SuspendLayout();
            // 
            // deviceCB
            // 
            this.deviceCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.deviceCB.FormattingEnabled = true;
            this.deviceCB.Location = new System.Drawing.Point(12, 146);
            this.deviceCB.Name = "deviceCB";
            this.deviceCB.Size = new System.Drawing.Size(121, 21);
            this.deviceCB.TabIndex = 31;
            this.deviceCB.SelectedIndexChanged += new System.EventHandler(this.deviceCB_SelectedIndexChanged);
            // 
            // COMPortCB
            // 
            this.COMPortCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.COMPortCB.FormattingEnabled = true;
            this.COMPortCB.Location = new System.Drawing.Point(12, 173);
            this.COMPortCB.Name = "COMPortCB";
            this.COMPortCB.Size = new System.Drawing.Size(121, 21);
            this.COMPortCB.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(259, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Speed";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Sensitivity";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(259, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Intensity";
            // 
            // FADE
            // 
            this.FADE.AutoSize = true;
            this.FADE.Location = new System.Drawing.Point(12, 122);
            this.FADE.Name = "FADE";
            this.FADE.Size = new System.Drawing.Size(49, 17);
            this.FADE.TabIndex = 26;
            this.FADE.TabStop = true;
            this.FADE.Text = "Fade";
            this.FADE.UseVisualStyleBackColor = true;
            this.FADE.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // BEAT
            // 
            this.BEAT.AutoSize = true;
            this.BEAT.Location = new System.Drawing.Point(12, 99);
            this.BEAT.Name = "BEAT";
            this.BEAT.Size = new System.Drawing.Size(47, 17);
            this.BEAT.TabIndex = 25;
            this.BEAT.TabStop = true;
            this.BEAT.Text = "Beat";
            this.BEAT.UseVisualStyleBackColor = true;
            this.BEAT.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // LEVELS
            // 
            this.LEVELS.AutoSize = true;
            this.LEVELS.Location = new System.Drawing.Point(12, 76);
            this.LEVELS.Name = "LEVELS";
            this.LEVELS.Size = new System.Drawing.Size(77, 17);
            this.LEVELS.TabIndex = 24;
            this.LEVELS.TabStop = true;
            this.LEVELS.Text = "Bass Level";
            this.LEVELS.UseVisualStyleBackColor = true;
            this.LEVELS.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // OFF
            // 
            this.OFF.AutoSize = true;
            this.OFF.Location = new System.Drawing.Point(12, 53);
            this.OFF.Name = "OFF";
            this.OFF.Size = new System.Drawing.Size(45, 17);
            this.OFF.TabIndex = 23;
            this.OFF.TabStop = true;
            this.OFF.Text = "OFF";
            this.OFF.UseVisualStyleBackColor = true;
            this.OFF.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // ON
            // 
            this.ON.AutoSize = true;
            this.ON.Checked = true;
            this.ON.Location = new System.Drawing.Point(12, 30);
            this.ON.Name = "ON";
            this.ON.Size = new System.Drawing.Size(41, 17);
            this.ON.TabIndex = 22;
            this.ON.TabStop = true;
            this.ON.Text = "ON";
            this.ON.UseVisualStyleBackColor = true;
            this.ON.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // speedTB
            // 
            this.speedTB.Location = new System.Drawing.Point(166, 161);
            this.speedTB.Maximum = 50;
            this.speedTB.Minimum = 1;
            this.speedTB.Name = "speedTB";
            this.speedTB.Size = new System.Drawing.Size(224, 45);
            this.speedTB.TabIndex = 21;
            this.speedTB.TickFrequency = 5;
            this.speedTB.Value = 3;
            this.speedTB.Scroll += new System.EventHandler(this.speedTB_Scroll);
            this.speedTB.MouseUp += new System.Windows.Forms.MouseEventHandler(this.speedTB_MouseUp);
            // 
            // IntensityTB
            // 
            this.IntensityTB.LargeChange = 50;
            this.IntensityTB.Location = new System.Drawing.Point(166, 25);
            this.IntensityTB.Maximum = 255;
            this.IntensityTB.Name = "IntensityTB";
            this.IntensityTB.Size = new System.Drawing.Size(224, 45);
            this.IntensityTB.SmallChange = 10;
            this.IntensityTB.TabIndex = 20;
            this.IntensityTB.TickFrequency = 20;
            this.IntensityTB.Value = 255;
            this.IntensityTB.Scroll += new System.EventHandler(this.IntensityTB_Scroll);
            this.IntensityTB.MouseUp += new System.Windows.Forms.MouseEventHandler(this.IntensityTB_MouseUp);
            // 
            // sensitivityTB
            // 
            this.sensitivityTB.Location = new System.Drawing.Point(166, 91);
            this.sensitivityTB.Maximum = 900;
            this.sensitivityTB.Minimum = 300;
            this.sensitivityTB.Name = "sensitivityTB";
            this.sensitivityTB.Size = new System.Drawing.Size(224, 45);
            this.sensitivityTB.TabIndex = 19;
            this.sensitivityTB.TickFrequency = 50;
            this.sensitivityTB.Value = 450;
            this.sensitivityTB.Scroll += new System.EventHandler(this.sensitivityTB_Scroll);
            this.sensitivityTB.MouseUp += new System.Windows.Forms.MouseEventHandler(this.sensitivityTB_MouseUp);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 208);
            this.Controls.Add(this.deviceCB);
            this.Controls.Add(this.COMPortCB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FADE);
            this.Controls.Add(this.BEAT);
            this.Controls.Add(this.LEVELS);
            this.Controls.Add(this.OFF);
            this.Controls.Add(this.ON);
            this.Controls.Add(this.speedTB);
            this.Controls.Add(this.IntensityTB);
            this.Controls.Add(this.sensitivityTB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsForm";
            this.Text = "Settings";
            this.Shown += new System.EventHandler(this.SettingsForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.speedTB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IntensityTB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sensitivityTB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox deviceCB;
        private System.Windows.Forms.ComboBox COMPortCB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton FADE;
        private System.Windows.Forms.RadioButton BEAT;
        private System.Windows.Forms.RadioButton LEVELS;
        private System.Windows.Forms.RadioButton OFF;
        private System.Windows.Forms.RadioButton ON;
        private System.Windows.Forms.TrackBar speedTB;
        private System.Windows.Forms.TrackBar IntensityTB;
        private System.Windows.Forms.TrackBar sensitivityTB;
    }
}