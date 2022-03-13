
namespace AMD_APU_Tuning_Utility
{
    partial class GPUOC
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
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.nudMem = new System.Windows.Forms.NumericUpDown();
            this.tbMem = new System.Windows.Forms.TrackBar();
            this.nudCore = new System.Windows.Forms.NumericUpDown();
            this.tbCore = new System.Windows.Forms.TrackBar();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbStatic = new System.Windows.Forms.TrackBar();
            this.nudStatic = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.rbStatic = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbNVidia = new System.Windows.Forms.CheckBox();
            this.cbiGPUOC = new System.Windows.Forms.CheckBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.Theme = new System.Windows.Forms.Timer(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.nudcoGFX = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.cbcoGFXMag = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudMem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbStatic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStatic)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudcoGFX)).BeginInit();
            this.SuspendLayout();
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(100, 342);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(17, 18);
            this.label22.TabIndex = 194;
            this.label22.Text = "+";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(100, 279);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(17, 18);
            this.label21.TabIndex = 193;
            this.label21.Text = "+";
            // 
            // nudMem
            // 
            this.nudMem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudMem.Location = new System.Drawing.Point(40, 341);
            this.nudMem.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.nudMem.Name = "nudMem";
            this.nudMem.Size = new System.Drawing.Size(56, 22);
            this.nudMem.TabIndex = 190;
            this.nudMem.ValueChanged += new System.EventHandler(this.nudMem_ValueChanged);
            // 
            // tbMem
            // 
            this.tbMem.LargeChange = 20;
            this.tbMem.Location = new System.Drawing.Point(123, 341);
            this.tbMem.Maximum = 300;
            this.tbMem.Name = "tbMem";
            this.tbMem.Size = new System.Drawing.Size(300, 45);
            this.tbMem.SmallChange = 10;
            this.tbMem.TabIndex = 192;
            this.tbMem.TickFrequency = 30;
            this.tbMem.Scroll += new System.EventHandler(this.tbMem_Scroll);
            // 
            // nudCore
            // 
            this.nudCore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCore.Location = new System.Drawing.Point(40, 278);
            this.nudCore.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.nudCore.Name = "nudCore";
            this.nudCore.Size = new System.Drawing.Size(56, 22);
            this.nudCore.TabIndex = 189;
            this.nudCore.ValueChanged += new System.EventHandler(this.nudCore_ValueChanged);
            // 
            // tbCore
            // 
            this.tbCore.LargeChange = 20;
            this.tbCore.Location = new System.Drawing.Point(123, 278);
            this.tbCore.Maximum = 250;
            this.tbCore.Name = "tbCore";
            this.tbCore.Size = new System.Drawing.Size(300, 45);
            this.tbCore.SmallChange = 10;
            this.tbCore.TabIndex = 191;
            this.tbCore.TickFrequency = 25;
            this.tbCore.Scroll += new System.EventHandler(this.tbCore_Scroll);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(36, 320);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(110, 18);
            this.label20.TabIndex = 188;
            this.label20.Text = "Memory Clock:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(37, 257);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(88, 18);
            this.label19.TabIndex = 187;
            this.label19.Text = "Core Clock:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(9, 233);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 24);
            this.label1.TabIndex = 154;
            this.label1.Text = "NVidia dGPU Clock Control:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(9, 10);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(252, 24);
            this.label4.TabIndex = 153;
            this.label4.Text = "Radeon iGPU Clock Control: ";
            // 
            // tbStatic
            // 
            this.tbStatic.LargeChange = 100;
            this.tbStatic.Location = new System.Drawing.Point(136, 95);
            this.tbStatic.Maximum = 2400;
            this.tbStatic.Minimum = 200;
            this.tbStatic.Name = "tbStatic";
            this.tbStatic.Size = new System.Drawing.Size(300, 45);
            this.tbStatic.SmallChange = 50;
            this.tbStatic.TabIndex = 210;
            this.tbStatic.TickFrequency = 100;
            this.tbStatic.Value = 1800;
            this.tbStatic.Scroll += new System.EventHandler(this.tbStatic_Scroll);
            // 
            // nudStatic
            // 
            this.nudStatic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudStatic.Location = new System.Drawing.Point(40, 95);
            this.nudStatic.Maximum = new decimal(new int[] {
            2400,
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
            this.nudStatic.TabIndex = 209;
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
            this.label2.Location = new System.Drawing.Point(37, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 18);
            this.label2.TabIndex = 208;
            this.label2.Text = "Static Clock:";
            // 
            // rbStatic
            // 
            this.rbStatic.AutoSize = true;
            this.rbStatic.Checked = true;
            this.rbStatic.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbStatic.Location = new System.Drawing.Point(730, 312);
            this.rbStatic.Name = "rbStatic";
            this.rbStatic.Size = new System.Drawing.Size(137, 22);
            this.rbStatic.TabIndex = 212;
            this.rbStatic.TabStop = true;
            this.rbStatic.Text = "Use Static Clock";
            this.rbStatic.UseVisualStyleBackColor = true;
            this.rbStatic.Visible = false;
            this.rbStatic.CheckedChanged += new System.EventHandler(this.rbStatic_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.cbNVidia);
            this.panel1.Controls.Add(this.cbiGPUOC);
            this.panel1.Controls.Add(this.btnApply);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.panel1.Location = new System.Drawing.Point(0, 458);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(870, 83);
            this.panel1.TabIndex = 213;
            // 
            // cbNVidia
            // 
            this.cbNVidia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cbNVidia.AutoSize = true;
            this.cbNVidia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNVidia.Location = new System.Drawing.Point(13, 44);
            this.cbNVidia.Name = "cbNVidia";
            this.cbNVidia.Size = new System.Drawing.Size(186, 22);
            this.cbNVidia.TabIndex = 75;
            this.cbNVidia.Text = "Overclock NVidia dGPU";
            this.cbNVidia.UseVisualStyleBackColor = true;
            // 
            // cbiGPUOC
            // 
            this.cbiGPUOC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cbiGPUOC.AutoSize = true;
            this.cbiGPUOC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbiGPUOC.Location = new System.Drawing.Point(13, 17);
            this.cbiGPUOC.Name = "cbiGPUOC";
            this.cbiGPUOC.Size = new System.Drawing.Size(135, 22);
            this.cbiGPUOC.TabIndex = 74;
            this.cbiGPUOC.Text = "Overclock iGPU";
            this.cbiGPUOC.UseVisualStyleBackColor = true;
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
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label14.Location = new System.Drawing.Point(10, 389);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(351, 36);
            this.label14.TabIndex = 220;
            this.label14.Text = "Warning: Overclocking can cause stability issues or \r\neven damage  to hardware th" +
    "at we are not liable for. ";
            // 
            // Theme
            // 
            this.Theme.Enabled = true;
            this.Theme.Interval = 500;
            this.Theme.Tick += new System.EventHandler(this.Theme_Tick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(37, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(363, 32);
            this.label7.TabIndex = 214;
            this.label7.Text = "iGPU overclocking only works on the 4000 series and select \r\n5000U series APUs e." +
    "g. 5300U, 5500U, 5700U";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label13.Location = new System.Drawing.Point(100, 98);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(34, 16);
            this.label13.TabIndex = 219;
            this.label13.Text = "MHz";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label15.Location = new System.Drawing.Point(34, 126);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(395, 32);
            this.label15.TabIndex = 220;
            this.label15.Text = "iGPU overclocking will cause the clock speed to be locked to\r\nwhat you set and wi" +
    "ll require a system reboot to go back to normal";
            // 
            // nudcoGFX
            // 
            this.nudcoGFX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudcoGFX.Location = new System.Drawing.Point(37, 184);
            this.nudcoGFX.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudcoGFX.Name = "nudcoGFX";
            this.nudcoGFX.Size = new System.Drawing.Size(56, 22);
            this.nudcoGFX.TabIndex = 222;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 18);
            this.label5.TabIndex = 221;
            this.label5.Text = "Curve Optimiser GFX:";
            // 
            // cbcoGFXMag
            // 
            this.cbcoGFXMag.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbcoGFXMag.FormattingEnabled = true;
            this.cbcoGFXMag.Items.AddRange(new object[] {
            "+ Positive",
            "- Negative"});
            this.cbcoGFXMag.Location = new System.Drawing.Point(100, 185);
            this.cbcoGFXMag.Name = "cbcoGFXMag";
            this.cbcoGFXMag.Size = new System.Drawing.Size(96, 21);
            this.cbcoGFXMag.TabIndex = 223;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(33, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(375, 16);
            this.label3.TabIndex = 224;
            this.label3.Text = "iGPU over/undervolting. leave at 0 for no chnages to be made.";
            // 
            // GPUOC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbcoGFXMag);
            this.Controls.Add(this.nudcoGFX);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rbStatic);
            this.Controls.Add(this.tbStatic);
            this.Controls.Add(this.nudStatic);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.nudMem);
            this.Controls.Add(this.tbMem);
            this.Controls.Add(this.nudCore);
            this.Controls.Add(this.tbCore);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Name = "GPUOC";
            this.Size = new System.Drawing.Size(870, 541);
            this.Load += new System.EventHandler(this.GPUOC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudMem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbStatic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStatic)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudcoGFX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.NumericUpDown nudMem;
        private System.Windows.Forms.TrackBar tbMem;
        private System.Windows.Forms.NumericUpDown nudCore;
        private System.Windows.Forms.TrackBar tbCore;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar tbStatic;
        private System.Windows.Forms.NumericUpDown nudStatic;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbStatic;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Timer Theme;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox cbNVidia;
        private System.Windows.Forms.CheckBox cbiGPUOC;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown nudcoGFX;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbcoGFXMag;
        private System.Windows.Forms.Label label3;
    }
}
