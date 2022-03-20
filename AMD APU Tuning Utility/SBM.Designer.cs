namespace AMD_APU_Tuning_Utility
{
    partial class SBM
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
            this.batteryTimer = new System.Windows.Forms.Timer(this.components);
            this.lblBattery = new System.Windows.Forms.Label();
            this.lblPerformance = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEnabled = new System.Windows.Forms.Button();
            this.Theme = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // batteryTimer
            // 
            this.batteryTimer.Enabled = true;
            this.batteryTimer.Interval = 2000;
            this.batteryTimer.Tick += new System.EventHandler(this.batteryTimer_Tick);
            // 
            // lblBattery
            // 
            this.lblBattery.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBattery.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBattery.Location = new System.Drawing.Point(0, 120);
            this.lblBattery.Name = "lblBattery";
            this.lblBattery.Size = new System.Drawing.Size(842, 55);
            this.lblBattery.TabIndex = 0;
            this.lblBattery.Text = "Battery Life: ";
            this.lblBattery.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPerformance
            // 
            this.lblPerformance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPerformance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerformance.Location = new System.Drawing.Point(0, 184);
            this.lblPerformance.Name = "lblPerformance";
            this.lblPerformance.Size = new System.Drawing.Size(842, 91);
            this.lblPerformance.TabIndex = 1;
            this.lblPerformance.Text = "Performance Status: ";
            this.lblPerformance.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 425);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(616, 75);
            this.label1.TabIndex = 2;
            this.label1.Text = "For the best experience possible, if you have a dGPU, lock all applications to you" +
    "r iGPU to save power.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // btnEnabled
            // 
            this.btnEnabled.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEnabled.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(166)))));
            this.btnEnabled.FlatAppearance.BorderSize = 0;
            this.btnEnabled.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnabled.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnabled.ForeColor = System.Drawing.Color.White;
            this.btnEnabled.Location = new System.Drawing.Point(238, 281);
            this.btnEnabled.Margin = new System.Windows.Forms.Padding(6);
            this.btnEnabled.Name = "btnEnabled";
            this.btnEnabled.Size = new System.Drawing.Size(333, 49);
            this.btnEnabled.TabIndex = 3;
            this.btnEnabled.Text = "Start Adaptive ECO Mode";
            this.btnEnabled.UseVisualStyleBackColor = false;
            this.btnEnabled.Click += new System.EventHandler(this.btnEnabled_Click);
            // 
            // Theme
            // 
            this.Theme.Enabled = true;
            this.Theme.Interval = 500;
            this.Theme.Tick += new System.EventHandler(this.Theme_Tick);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(0, 348);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(842, 55);
            this.label2.TabIndex = 4;
            this.label2.Text = "You must stop Adaptive ECO Mode before closing AATU to revert power plan changes!" +
    "!!!";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // SBM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEnabled);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPerformance);
            this.Controls.Add(this.lblBattery);
            this.Name = "SBM";
            this.Size = new System.Drawing.Size(842, 509);
            this.Load += new System.EventHandler(this.SBM_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer batteryTimer;
        private System.Windows.Forms.Label lblBattery;
        private System.Windows.Forms.Label lblPerformance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEnabled;
        private System.Windows.Forms.Timer Theme;
        private System.Windows.Forms.Label label2;
    }
}
