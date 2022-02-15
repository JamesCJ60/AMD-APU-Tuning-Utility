
namespace AMD_APU_Tuning_Utility
{
    partial class SysInfo
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
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCPUInfo = new System.Windows.Forms.ListBox();
            this.lblGPUInfo = new System.Windows.Forms.ListBox();
            this.lblStorageInfo = new System.Windows.Forms.ListBox();
            this.DetailsUpdater = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(17, 8);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "CPU:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(17, 171);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "GPU:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(17, 333);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "Storage:";
            // 
            // lblCPUInfo
            // 
            this.lblCPUInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCPUInfo.BackColor = System.Drawing.Color.Gainsboro;
            this.lblCPUInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblCPUInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPUInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCPUInfo.FormattingEnabled = true;
            this.lblCPUInfo.ItemHeight = 20;
            this.lblCPUInfo.Location = new System.Drawing.Point(90, 36);
            this.lblCPUInfo.Margin = new System.Windows.Forms.Padding(5);
            this.lblCPUInfo.Name = "lblCPUInfo";
            this.lblCPUInfo.Size = new System.Drawing.Size(669, 120);
            this.lblCPUInfo.TabIndex = 12;
            // 
            // lblGPUInfo
            // 
            this.lblGPUInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGPUInfo.BackColor = System.Drawing.Color.Gainsboro;
            this.lblGPUInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblGPUInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGPUInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblGPUInfo.FormattingEnabled = true;
            this.lblGPUInfo.ItemHeight = 20;
            this.lblGPUInfo.Location = new System.Drawing.Point(90, 197);
            this.lblGPUInfo.Margin = new System.Windows.Forms.Padding(5);
            this.lblGPUInfo.Name = "lblGPUInfo";
            this.lblGPUInfo.Size = new System.Drawing.Size(669, 120);
            this.lblGPUInfo.TabIndex = 13;
            // 
            // lblStorageInfo
            // 
            this.lblStorageInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStorageInfo.BackColor = System.Drawing.Color.Gainsboro;
            this.lblStorageInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblStorageInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStorageInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblStorageInfo.FormattingEnabled = true;
            this.lblStorageInfo.ItemHeight = 20;
            this.lblStorageInfo.Location = new System.Drawing.Point(90, 365);
            this.lblStorageInfo.Margin = new System.Windows.Forms.Padding(5);
            this.lblStorageInfo.Name = "lblStorageInfo";
            this.lblStorageInfo.Size = new System.Drawing.Size(669, 120);
            this.lblStorageInfo.TabIndex = 14;
            // 
            // DetailsUpdater
            // 
            this.DetailsUpdater.Enabled = true;
            this.DetailsUpdater.Interval = 60000;
            this.DetailsUpdater.Tick += new System.EventHandler(this.DetailsUpdater_Tick);
            // 
            // SysInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.lblStorageInfo);
            this.Controls.Add(this.lblGPUInfo);
            this.Controls.Add(this.lblCPUInfo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Name = "SysInfo";
            this.Size = new System.Drawing.Size(842, 509);
            this.Load += new System.EventHandler(this.SysInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lblCPUInfo;
        private System.Windows.Forms.ListBox lblGPUInfo;
        private System.Windows.Forms.ListBox lblStorageInfo;
        private System.Windows.Forms.Timer DetailsUpdater;
    }
}
