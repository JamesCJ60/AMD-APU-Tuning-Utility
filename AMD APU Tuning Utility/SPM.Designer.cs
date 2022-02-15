namespace AMD_APU_Tuning_Utility
{
    partial class SPM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SPM));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbTBOCPU = new System.Windows.Forms.CheckBox();
            this.cbPerf = new System.Windows.Forms.CheckBox();
            this.cbTBOGPU = new System.Windows.Forms.CheckBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.nudTemp = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbMaxTDP = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nudMaxTDP = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nudGPU = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.nudCPU = new System.Windows.Forms.NumericUpDown();
            this.Theme = new System.Windows.Forms.Timer(this.components);
            this.APMode = new System.Windows.Forms.Timer(this.components);
            this.label14 = new System.Windows.Forms.Label();
            this.lblTest1 = new System.Windows.Forms.Label();
            this.lblTest2 = new System.Windows.Forms.Label();
            this.lblTest3 = new System.Windows.Forms.Label();
            this.lblTest4 = new System.Windows.Forms.Label();
            this.lblTest5 = new System.Windows.Forms.Label();
            this.lblTest6 = new System.Windows.Forms.Label();
            this.lblTest7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTemp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxTDP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCPU)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.cbTBOCPU);
            this.panel1.Controls.Add(this.cbPerf);
            this.panel1.Controls.Add(this.cbTBOGPU);
            this.panel1.Controls.Add(this.btnApply);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.panel1.Location = new System.Drawing.Point(0, 426);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(842, 83);
            this.panel1.TabIndex = 214;
            // 
            // cbTBOCPU
            // 
            this.cbTBOCPU.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cbTBOCPU.AutoSize = true;
            this.cbTBOCPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTBOCPU.Location = new System.Drawing.Point(11, 54);
            this.cbTBOCPU.Name = "cbTBOCPU";
            this.cbTBOCPU.Size = new System.Drawing.Size(213, 22);
            this.cbTBOCPU.TabIndex = 76;
            this.cbTBOCPU.Text = "Turbo Boost Overdrive CPU";
            this.cbTBOCPU.UseVisualStyleBackColor = true;
            this.cbTBOCPU.CheckedChanged += new System.EventHandler(this.cbTBOCPU_CheckedChanged);
            // 
            // cbPerf
            // 
            this.cbPerf.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cbPerf.AutoSize = true;
            this.cbPerf.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPerf.Location = new System.Drawing.Point(11, 7);
            this.cbPerf.Name = "cbPerf";
            this.cbPerf.Size = new System.Drawing.Size(206, 22);
            this.cbPerf.TabIndex = 75;
            this.cbPerf.Text = "Adaptive Performance TDP";
            this.cbPerf.UseVisualStyleBackColor = true;
            this.cbPerf.CheckedChanged += new System.EventHandler(this.cbPerf_CheckedChanged);
            // 
            // cbTBOGPU
            // 
            this.cbTBOGPU.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cbTBOGPU.AutoSize = true;
            this.cbTBOGPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTBOGPU.Location = new System.Drawing.Point(11, 31);
            this.cbTBOGPU.Name = "cbTBOGPU";
            this.cbTBOGPU.Size = new System.Drawing.Size(217, 22);
            this.cbTBOGPU.TabIndex = 74;
            this.cbTBOGPU.Text = "Turbo Boost Overdrive iGPU";
            this.cbTBOGPU.UseVisualStyleBackColor = true;
            this.cbTBOGPU.CheckedChanged += new System.EventHandler(this.cbTBOGPU_CheckedChanged);
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
            this.btnApply.Location = new System.Drawing.Point(671, 18);
            this.btnApply.Margin = new System.Windows.Forms.Padding(6);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(153, 49);
            this.btnApply.TabIndex = 0;
            this.btnApply.Text = "Start AP Mode";
            this.btnApply.UseVisualStyleBackColor = false;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // nudTemp
            // 
            this.nudTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudTemp.Location = new System.Drawing.Point(141, 39);
            this.nudTemp.Maximum = new decimal(new int[] {
            105,
            0,
            0,
            0});
            this.nudTemp.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudTemp.Name = "nudTemp";
            this.nudTemp.Size = new System.Drawing.Size(56, 22);
            this.nudTemp.TabIndex = 215;
            this.nudTemp.Value = new decimal(new int[] {
            105,
            0,
            0,
            0});
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label13.Location = new System.Drawing.Point(199, 43);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(20, 16);
            this.label13.TabIndex = 220;
            this.label13.Text = "°C";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 18);
            this.label2.TabIndex = 221;
            this.label2.Text = "Temp Limit:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(7, 12);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(353, 24);
            this.label4.TabIndex = 222;
            this.label4.Text = "Adaptive Performance Mode Temp Limit:";
            // 
            // cbMaxTDP
            // 
            this.cbMaxTDP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cbMaxTDP.AutoSize = true;
            this.cbMaxTDP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.cbMaxTDP.Location = new System.Drawing.Point(11, 67);
            this.cbMaxTDP.Name = "cbMaxTDP";
            this.cbMaxTDP.Size = new System.Drawing.Size(357, 28);
            this.cbMaxTDP.TabIndex = 223;
            this.cbMaxTDP.Text = "Adaptive Performance Mode Max TDP:";
            this.cbMaxTDP.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 18);
            this.label1.TabIndex = 226;
            this.label1.Text = "Max TDP:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(199, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 16);
            this.label3.TabIndex = 225;
            this.label3.Text = "W";
            // 
            // nudMaxTDP
            // 
            this.nudMaxTDP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudMaxTDP.Location = new System.Drawing.Point(141, 96);
            this.nudMaxTDP.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nudMaxTDP.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudMaxTDP.Name = "nudMaxTDP";
            this.nudMaxTDP.Size = new System.Drawing.Size(56, 22);
            this.nudMaxTDP.TabIndex = 224;
            this.nudMaxTDP.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(6, 121);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(368, 24);
            this.label5.TabIndex = 230;
            this.label5.Text = "Turbo Boost Overdrive iGPU - Clock Offset:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(44, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 18);
            this.label6.TabIndex = 229;
            this.label6.Text = "Clock Offset:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(198, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 16);
            this.label7.TabIndex = 228;
            this.label7.Text = "+ MHz";
            // 
            // nudGPU
            // 
            this.nudGPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudGPU.Increment = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nudGPU.Location = new System.Drawing.Point(140, 148);
            this.nudGPU.Maximum = new decimal(new int[] {
            800,
            0,
            0,
            0});
            this.nudGPU.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nudGPU.Name = "nudGPU";
            this.nudGPU.Size = new System.Drawing.Size(56, 22);
            this.nudGPU.TabIndex = 227;
            this.nudGPU.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(6, 173);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(363, 24);
            this.label8.TabIndex = 234;
            this.label8.Text = "Turbo Boost Overdrive CPU - Clock Offset:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(44, 202);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 18);
            this.label9.TabIndex = 233;
            this.label9.Text = "Clock Offset:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label10.Location = new System.Drawing.Point(198, 204);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 16);
            this.label10.TabIndex = 232;
            this.label10.Text = "+ MHz";
            // 
            // nudCPU
            // 
            this.nudCPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCPU.Increment = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nudCPU.Location = new System.Drawing.Point(140, 200);
            this.nudCPU.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.nudCPU.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nudCPU.Name = "nudCPU";
            this.nudCPU.Size = new System.Drawing.Size(56, 22);
            this.nudCPU.TabIndex = 231;
            this.nudCPU.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // Theme
            // 
            this.Theme.Enabled = true;
            this.Theme.Interval = 500;
            this.Theme.Tick += new System.EventHandler(this.Theme_Tick);
            // 
            // APMode
            // 
            this.APMode.Enabled = true;
            this.APMode.Interval = 1650;
            this.APMode.Tick += new System.EventHandler(this.APMode_Tick);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label14.Location = new System.Drawing.Point(7, 228);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(591, 112);
            this.label14.TabIndex = 235;
            this.label14.Text = resources.GetString("label14.Text");
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // lblTest1
            // 
            this.lblTest1.AutoSize = true;
            this.lblTest1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTest1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTest1.Location = new System.Drawing.Point(460, 105);
            this.lblTest1.Name = "lblTest1";
            this.lblTest1.Size = new System.Drawing.Size(34, 16);
            this.lblTest1.TabIndex = 236;
            this.lblTest1.Text = "Test";
            this.lblTest1.Visible = false;
            // 
            // lblTest2
            // 
            this.lblTest2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTest2.ForeColor = System.Drawing.Color.Black;
            this.lblTest2.Location = new System.Drawing.Point(8, 348);
            this.lblTest2.Name = "lblTest2";
            this.lblTest2.Size = new System.Drawing.Size(533, 72);
            this.lblTest2.TabIndex = 237;
            // 
            // lblTest3
            // 
            this.lblTest3.AutoSize = true;
            this.lblTest3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTest3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTest3.Location = new System.Drawing.Point(460, 20);
            this.lblTest3.Name = "lblTest3";
            this.lblTest3.Size = new System.Drawing.Size(34, 16);
            this.lblTest3.TabIndex = 238;
            this.lblTest3.Text = "Test";
            this.lblTest3.Visible = false;
            // 
            // lblTest4
            // 
            this.lblTest4.AutoSize = true;
            this.lblTest4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTest4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTest4.Location = new System.Drawing.Point(460, 39);
            this.lblTest4.Name = "lblTest4";
            this.lblTest4.Size = new System.Drawing.Size(34, 16);
            this.lblTest4.TabIndex = 239;
            this.lblTest4.Text = "Test";
            this.lblTest4.Visible = false;
            // 
            // lblTest5
            // 
            this.lblTest5.AutoSize = true;
            this.lblTest5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTest5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTest5.Location = new System.Drawing.Point(460, 57);
            this.lblTest5.Name = "lblTest5";
            this.lblTest5.Size = new System.Drawing.Size(34, 16);
            this.lblTest5.TabIndex = 240;
            this.lblTest5.Text = "Test";
            this.lblTest5.Visible = false;
            // 
            // lblTest6
            // 
            this.lblTest6.AutoSize = true;
            this.lblTest6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTest6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTest6.Location = new System.Drawing.Point(460, 73);
            this.lblTest6.Name = "lblTest6";
            this.lblTest6.Size = new System.Drawing.Size(34, 16);
            this.lblTest6.TabIndex = 241;
            this.lblTest6.Text = "Test";
            this.lblTest6.Visible = false;
            // 
            // lblTest7
            // 
            this.lblTest7.AutoSize = true;
            this.lblTest7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTest7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTest7.Location = new System.Drawing.Point(460, 89);
            this.lblTest7.Name = "lblTest7";
            this.lblTest7.Size = new System.Drawing.Size(34, 16);
            this.lblTest7.TabIndex = 242;
            this.lblTest7.Text = "Test";
            this.lblTest7.Visible = false;
            // 
            // SPM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.lblTest7);
            this.Controls.Add(this.lblTest6);
            this.Controls.Add(this.lblTest5);
            this.Controls.Add(this.lblTest4);
            this.Controls.Add(this.lblTest3);
            this.Controls.Add(this.lblTest2);
            this.Controls.Add(this.lblTest1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.nudCPU);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.nudGPU);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nudMaxTDP);
            this.Controls.Add(this.cbMaxTDP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.nudTemp);
            this.Controls.Add(this.panel1);
            this.Name = "SPM";
            this.Size = new System.Drawing.Size(842, 509);
            this.Load += new System.EventHandler(this.SPM_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTemp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxTDP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCPU)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox cbTBOCPU;
        private System.Windows.Forms.CheckBox cbPerf;
        private System.Windows.Forms.CheckBox cbTBOGPU;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.NumericUpDown nudTemp;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cbMaxTDP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudMaxTDP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nudGPU;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown nudCPU;
        private System.Windows.Forms.Timer Theme;
        private System.Windows.Forms.Timer APMode;
        private System.Windows.Forms.Label label14;
        public System.Windows.Forms.Label lblTest1;
        public System.Windows.Forms.Label lblTest2;
        public System.Windows.Forms.Label lblTest3;
        public System.Windows.Forms.Label lblTest4;
        public System.Windows.Forms.Label lblTest5;
        public System.Windows.Forms.Label lblTest6;
        public System.Windows.Forms.Label lblTest7;
    }
}
