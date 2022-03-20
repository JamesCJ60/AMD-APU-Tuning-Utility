namespace AMD_APU_Tuning_Utility
{
    partial class CPUOC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDisable = new System.Windows.Forms.Button();
            this.cbVID = new System.Windows.Forms.CheckBox();
            this.cbOverClockCPU = new System.Windows.Forms.CheckBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbcoCPUMag = new System.Windows.Forms.ComboBox();
            this.nudcoCPU = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tbStatic = new System.Windows.Forms.TrackBar();
            this.nudStatic = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.Theme = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nudVID = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.cbCPUCO = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudcoCPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbStatic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStatic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVID)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.cbCPUCO);
            this.panel1.Controls.Add(this.btnDisable);
            this.panel1.Controls.Add(this.cbVID);
            this.panel1.Controls.Add(this.cbOverClockCPU);
            this.panel1.Controls.Add(this.btnApply);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.panel1.Location = new System.Drawing.Point(0, 458);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(870, 83);
            this.panel1.TabIndex = 214;
            // 
            // btnDisable
            // 
            this.btnDisable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDisable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(166)))));
            this.btnDisable.FlatAppearance.BorderSize = 0;
            this.btnDisable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisable.ForeColor = System.Drawing.Color.White;
            this.btnDisable.Location = new System.Drawing.Point(534, 18);
            this.btnDisable.Margin = new System.Windows.Forms.Padding(6);
            this.btnDisable.Name = "btnDisable";
            this.btnDisable.Size = new System.Drawing.Size(153, 49);
            this.btnDisable.TabIndex = 76;
            this.btnDisable.Text = "Disable OC";
            this.btnDisable.UseVisualStyleBackColor = false;
            this.btnDisable.Click += new System.EventHandler(this.btnDisable_Click);
            // 
            // cbVID
            // 
            this.cbVID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cbVID.AutoSize = true;
            this.cbVID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbVID.Location = new System.Drawing.Point(13, 53);
            this.cbVID.Name = "cbVID";
            this.cbVID.Size = new System.Drawing.Size(125, 22);
            this.cbVID.TabIndex = 75;
            this.cbVID.Text = "Apply CPU VID";
            this.cbVID.UseVisualStyleBackColor = true;
            // 
            // cbOverClockCPU
            // 
            this.cbOverClockCPU.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cbOverClockCPU.AutoSize = true;
            this.cbOverClockCPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOverClockCPU.Location = new System.Drawing.Point(13, 7);
            this.cbOverClockCPU.Name = "cbOverClockCPU";
            this.cbOverClockCPU.Size = new System.Drawing.Size(131, 22);
            this.cbOverClockCPU.TabIndex = 74;
            this.cbOverClockCPU.Text = "Overclock CPU";
            this.cbOverClockCPU.UseVisualStyleBackColor = true;
            // 
            // btnApply
            // 
            this.btnApply.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(166)))));
            this.btnApply.FlatAppearance.BorderSize = 0;
            this.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApply.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApply.ForeColor = System.Drawing.Color.White;
            this.btnApply.Location = new System.Drawing.Point(699, 18);
            this.btnApply.Margin = new System.Windows.Forms.Padding(6);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(153, 49);
            this.btnApply.TabIndex = 0;
            this.btnApply.Text = "Apply Settings";
            this.btnApply.UseVisualStyleBackColor = false;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(30, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(375, 16);
            this.label3.TabIndex = 235;
            this.label3.Text = "CPU over/undervolting. Leave at 0 for no chnages to be made.";
            // 
            // cbcoCPUMag
            // 
            this.cbcoCPUMag.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbcoCPUMag.FormattingEnabled = true;
            this.cbcoCPUMag.Items.AddRange(new object[] {
            "+ Positive",
            "- Negative"});
            this.cbcoCPUMag.Location = new System.Drawing.Point(97, 245);
            this.cbcoCPUMag.Name = "cbcoCPUMag";
            this.cbcoCPUMag.Size = new System.Drawing.Size(96, 21);
            this.cbcoCPUMag.TabIndex = 234;
            // 
            // nudcoCPU
            // 
            this.nudcoCPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudcoCPU.Location = new System.Drawing.Point(34, 244);
            this.nudcoCPU.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudcoCPU.Name = "nudcoCPU";
            this.nudcoCPU.Size = new System.Drawing.Size(56, 22);
            this.nudcoCPU.TabIndex = 233;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label5.Location = new System.Drawing.Point(3, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(222, 24);
            this.label5.TabIndex = 232;
            this.label5.Text = "Curve Optimiser All Core:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label13.Location = new System.Drawing.Point(100, 58);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(34, 16);
            this.label13.TabIndex = 230;
            this.label13.Text = "MHz";
            // 
            // tbStatic
            // 
            this.tbStatic.LargeChange = 100;
            this.tbStatic.Location = new System.Drawing.Point(136, 55);
            this.tbStatic.Maximum = 5500;
            this.tbStatic.Minimum = 200;
            this.tbStatic.Name = "tbStatic";
            this.tbStatic.Size = new System.Drawing.Size(300, 45);
            this.tbStatic.SmallChange = 50;
            this.tbStatic.TabIndex = 228;
            this.tbStatic.TickFrequency = 100;
            this.tbStatic.Value = 1800;
            this.tbStatic.Scroll += new System.EventHandler(this.tbStatic_Scroll);
            // 
            // nudStatic
            // 
            this.nudStatic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudStatic.Increment = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nudStatic.Location = new System.Drawing.Point(40, 55);
            this.nudStatic.Maximum = new decimal(new int[] {
            5500,
            0,
            0,
            0});
            this.nudStatic.Minimum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nudStatic.Name = "nudStatic";
            this.nudStatic.Size = new System.Drawing.Size(56, 22);
            this.nudStatic.TabIndex = 227;
            this.nudStatic.Value = new decimal(new int[] {
            1800,
            0,
            0,
            0});
            this.nudStatic.ValueChanged += new System.EventHandler(this.nudStatic_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 18);
            this.label2.TabIndex = 226;
            this.label2.Text = "Static Clock:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(9, 10);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 24);
            this.label4.TabIndex = 225;
            this.label4.Text = "CPU Clock Control: ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label14.Location = new System.Drawing.Point(36, 83);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(584, 32);
            this.label14.TabIndex = 236;
            this.label14.Text = "Warning: Overclocking can cause stability issues or even damage to hardware that" +
    " we are not \r\nliable for. Also, overclocking only works with unlocked APUs that a" +
    "re 4000-series-based and newer.";
            // 
            // Theme
            // 
            this.Theme.Enabled = true;
            this.Theme.Interval = 500;
            this.Theme.Tick += new System.EventHandler(this.Theme_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.Location = new System.Drawing.Point(9, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 24);
            this.label1.TabIndex = 237;
            this.label1.Text = "CPU VID:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(101, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 16);
            this.label6.TabIndex = 239;
            this.label6.Text = "mV";
            // 
            // nudVID
            // 
            this.nudVID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudVID.Increment = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nudVID.Location = new System.Drawing.Point(41, 147);
            this.nudVID.Maximum = new decimal(new int[] {
            1450,
            0,
            0,
            0});
            this.nudVID.Minimum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nudVID.Name = "nudVID";
            this.nudVID.Size = new System.Drawing.Size(56, 22);
            this.nudVID.TabIndex = 238;
            this.nudVID.Value = new decimal(new int[] {
            1250,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(38, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(576, 32);
            this.label7.TabIndex = 240;
            this.label7.Text = "Warning: Setting a high VID can cause damage to your APU in many ways especially " +
    "without the \r\nthermal headroom.\r\n";
            // 
            // cbCPUCO
            // 
            this.cbCPUCO.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cbCPUCO.AutoSize = true;
            this.cbCPUCO.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCPUCO.Location = new System.Drawing.Point(13, 30);
            this.cbCPUCO.Name = "cbCPUCO";
            this.cbCPUCO.Size = new System.Drawing.Size(173, 22);
            this.cbCPUCO.TabIndex = 77;
            this.cbCPUCO.Text = "Apply Curve Optimiser";
            this.cbCPUCO.UseVisualStyleBackColor = true;
            // 
            // CPUOC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nudVID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbcoCPUMag);
            this.Controls.Add(this.nudcoCPU);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.tbStatic);
            this.Controls.Add(this.nudStatic);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Name = "CPUOC";
            this.Size = new System.Drawing.Size(870, 541);
            this.Load += new System.EventHandler(this.CPUOC_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudcoCPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbStatic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStatic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox cbVID;
        private System.Windows.Forms.CheckBox cbOverClockCPU;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbcoCPUMag;
        private System.Windows.Forms.NumericUpDown nudcoCPU;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TrackBar tbStatic;
        private System.Windows.Forms.NumericUpDown nudStatic;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDisable;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Timer Theme;
        private System.Windows.Forms.CheckBox cbCPUCO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudVID;
        private System.Windows.Forms.Label label7;
    }
}
