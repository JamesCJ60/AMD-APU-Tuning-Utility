namespace AMD_APU_Tuning_Utility
{
    partial class PremadePresets
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
            this.btnimport = new System.Windows.Forms.Button();
            this.btnSensors = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lbPresetValues = new System.Windows.Forms.ListBox();
            this.cbAPUPreset = new System.Windows.Forms.ComboBox();
            this.cbAPUSeries = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Theme = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.btnimport);
            this.panel1.Controls.Add(this.btnSensors);
            this.panel1.Controls.Add(this.btnApply);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 400);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(820, 83);
            this.panel1.TabIndex = 0;
            // 
            // btnimport
            // 
            this.btnimport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnimport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(166)))));
            this.btnimport.Enabled = false;
            this.btnimport.FlatAppearance.BorderSize = 0;
            this.btnimport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnimport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnimport.ForeColor = System.Drawing.Color.White;
            this.btnimport.Location = new System.Drawing.Point(490, 18);
            this.btnimport.Name = "btnimport";
            this.btnimport.Size = new System.Drawing.Size(153, 49);
            this.btnimport.TabIndex = 2;
            this.btnimport.Text = "Import into Custom";
            this.btnimport.UseVisualStyleBackColor = false;
            this.btnimport.Click += new System.EventHandler(this.btnimport_Click);
            // 
            // btnSensors
            // 
            this.btnSensors.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSensors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(166)))));
            this.btnSensors.FlatAppearance.BorderSize = 0;
            this.btnSensors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSensors.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSensors.ForeColor = System.Drawing.Color.White;
            this.btnSensors.Location = new System.Drawing.Point(331, 18);
            this.btnSensors.Name = "btnSensors";
            this.btnSensors.Size = new System.Drawing.Size(153, 49);
            this.btnSensors.TabIndex = 1;
            this.btnSensors.Text = "Show Sensors";
            this.btnSensors.UseVisualStyleBackColor = false;
            this.btnSensors.Visible = false;
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
            this.btnApply.Location = new System.Drawing.Point(649, 18);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(153, 49);
            this.btnApply.TabIndex = 0;
            this.btnApply.Text = "Apply Settings";
            this.btnApply.UseVisualStyleBackColor = false;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lbPresetValues);
            this.panel2.Controls.Add(this.cbAPUPreset);
            this.panel2.Controls.Add(this.cbAPUSeries);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(820, 400);
            this.panel2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(68, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Settings being altered:";
            // 
            // lbPresetValues
            // 
            this.lbPresetValues.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPresetValues.BackColor = System.Drawing.Color.Gainsboro;
            this.lbPresetValues.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbPresetValues.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPresetValues.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbPresetValues.FormattingEnabled = true;
            this.lbPresetValues.ItemHeight = 20;
            this.lbPresetValues.Location = new System.Drawing.Point(72, 141);
            this.lbPresetValues.Name = "lbPresetValues";
            this.lbPresetValues.Size = new System.Drawing.Size(677, 240);
            this.lbPresetValues.TabIndex = 5;
            // 
            // cbAPUPreset
            // 
            this.cbAPUPreset.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cbAPUPreset.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbAPUPreset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAPUPreset.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbAPUPreset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAPUPreset.ForeColor = System.Drawing.Color.Black;
            this.cbAPUPreset.FormattingEnabled = true;
            this.cbAPUPreset.Location = new System.Drawing.Point(259, 63);
            this.cbAPUPreset.Name = "cbAPUPreset";
            this.cbAPUPreset.Size = new System.Drawing.Size(219, 24);
            this.cbAPUPreset.TabIndex = 4;
            this.cbAPUPreset.SelectedIndexChanged += new System.EventHandler(this.cbAPUPreset_SelectedIndexChanged);
            // 
            // cbAPUSeries
            // 
            this.cbAPUSeries.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cbAPUSeries.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbAPUSeries.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAPUSeries.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbAPUSeries.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAPUSeries.ForeColor = System.Drawing.Color.Black;
            this.cbAPUSeries.FormattingEnabled = true;
            this.cbAPUSeries.Items.AddRange(new object[] {
            "Ryzen 2000 Series U",
            "Ryzen 3000 Series U",
            "Ryzen 3000 Series H",
            "Ryzen 4000 Series U",
            "Ryzen 4000 Series H/HS",
            "Ryzen 5000 Series U",
            "Ryzen 5000 Series H/HS/HX",
            "Ryzen 6000 Series U",
            "Ryzen 6000 Series H/HS/HX"});
            this.cbAPUSeries.Location = new System.Drawing.Point(259, 20);
            this.cbAPUSeries.Name = "cbAPUSeries";
            this.cbAPUSeries.Size = new System.Drawing.Size(219, 24);
            this.cbAPUSeries.TabIndex = 3;
            this.cbAPUSeries.SelectedIndexChanged += new System.EventHandler(this.cbAPUSeries_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(68, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "APU/Device Preset:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(68, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "APU Series/Device:";
            // 
            // Theme
            // 
            this.Theme.Enabled = true;
            this.Theme.Interval = 500;
            this.Theme.Tick += new System.EventHandler(this.Theme_Tick);
            // 
            // PremadePresets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(96)))));
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "PremadePresets";
            this.Size = new System.Drawing.Size(820, 483);
            this.Load += new System.EventHandler(this.PremadePresets_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.ListBox lbPresetValues;
        private System.Windows.Forms.ComboBox cbAPUPreset;
        private System.Windows.Forms.ComboBox cbAPUSeries;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSensors;
        private System.Windows.Forms.Timer Theme;
        private System.Windows.Forms.Button btnimport;
    }
}
