using System.Windows.Forms;

namespace AMD_APU_Tuning_Utility
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnCPUOC = new System.Windows.Forms.Button();
            this.btnGPU = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnROG = new System.Windows.Forms.Button();
            this.btnSystemInfo = new System.Windows.Forms.Button();
            this.btnSmartP = new System.Windows.Forms.Button();
            this.btnSmartB = new System.Windows.Forms.Button();
            this.btnCPresets = new System.Windows.Forms.Button();
            this.btnPPresets = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.lblEd = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblVersion = new System.Windows.Forms.Label();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnPE = new System.Windows.Forms.Button();
            this.lblAPU = new System.Windows.Forms.Label();
            this.btnMinimise = new System.Windows.Forms.Button();
            this.btnMaximise = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.ThemeMain = new System.Windows.Forms.Timer(this.components);
            this.panelControl = new System.Windows.Forms.Panel();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.FormOpacity = new System.Windows.Forms.Timer(this.components);
            this.AutoReapply = new System.Windows.Forms.Timer(this.components);
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            this.panelContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.AutoScroll = true;
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.btnCPUOC);
            this.panelMenu.Controls.Add(this.btnGPU);
            this.panelMenu.Controls.Add(this.btnSettings);
            this.panelMenu.Controls.Add(this.btnROG);
            this.panelMenu.Controls.Add(this.btnSystemInfo);
            this.panelMenu.Controls.Add(this.btnSmartP);
            this.panelMenu.Controls.Add(this.btnSmartB);
            this.panelMenu.Controls.Add(this.btnCPresets);
            this.panelMenu.Controls.Add(this.btnPPresets);
            this.panelMenu.Controls.Add(this.btnHome);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(258, 626);
            this.panelMenu.TabIndex = 0;
            // 
            // btnCPUOC
            // 
            this.btnCPUOC.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCPUOC.FlatAppearance.BorderSize = 0;
            this.btnCPUOC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCPUOC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCPUOC.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCPUOC.Image = ((System.Drawing.Image)(resources.GetObject("btnCPUOC.Image")));
            this.btnCPUOC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCPUOC.Location = new System.Drawing.Point(0, 625);
            this.btnCPUOC.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnCPUOC.Name = "btnCPUOC";
            this.btnCPUOC.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.btnCPUOC.Size = new System.Drawing.Size(241, 60);
            this.btnCPUOC.TabIndex = 12;
            this.btnCPUOC.Text = "     CPU Overclocking";
            this.btnCPUOC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCPUOC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCPUOC.UseVisualStyleBackColor = true;
            this.btnCPUOC.Click += new System.EventHandler(this.btnCPUOC_Click);
            // 
            // btnGPU
            // 
            this.btnGPU.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGPU.FlatAppearance.BorderSize = 0;
            this.btnGPU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGPU.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnGPU.Image = ((System.Drawing.Image)(resources.GetObject("btnGPU.Image")));
            this.btnGPU.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGPU.Location = new System.Drawing.Point(0, 565);
            this.btnGPU.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnGPU.Name = "btnGPU";
            this.btnGPU.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.btnGPU.Size = new System.Drawing.Size(241, 60);
            this.btnGPU.TabIndex = 11;
            this.btnGPU.Text = "     GPU Overclocking";
            this.btnGPU.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGPU.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGPU.UseVisualStyleBackColor = true;
            this.btnGPU.Click += new System.EventHandler(this.btnGPU_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.Location = new System.Drawing.Point(0, 505);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.btnSettings.Size = new System.Drawing.Size(241, 60);
            this.btnSettings.TabIndex = 10;
            this.btnSettings.Text = "     Settings";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnROG
            // 
            this.btnROG.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnROG.FlatAppearance.BorderSize = 0;
            this.btnROG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnROG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnROG.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnROG.Image = ((System.Drawing.Image)(resources.GetObject("btnROG.Image")));
            this.btnROG.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnROG.Location = new System.Drawing.Point(0, 445);
            this.btnROG.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnROG.Name = "btnROG";
            this.btnROG.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.btnROG.Size = new System.Drawing.Size(241, 60);
            this.btnROG.TabIndex = 10;
            this.btnROG.Text = "     ROG AC Modes";
            this.btnROG.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnROG.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnROG.UseVisualStyleBackColor = true;
            this.btnROG.Click += new System.EventHandler(this.btnROG_Click);
            // 
            // btnSystemInfo
            // 
            this.btnSystemInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSystemInfo.FlatAppearance.BorderSize = 0;
            this.btnSystemInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSystemInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSystemInfo.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSystemInfo.Image = ((System.Drawing.Image)(resources.GetObject("btnSystemInfo.Image")));
            this.btnSystemInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSystemInfo.Location = new System.Drawing.Point(0, 385);
            this.btnSystemInfo.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnSystemInfo.Name = "btnSystemInfo";
            this.btnSystemInfo.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.btnSystemInfo.Size = new System.Drawing.Size(241, 60);
            this.btnSystemInfo.TabIndex = 6;
            this.btnSystemInfo.Text = "     System Info";
            this.btnSystemInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSystemInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSystemInfo.UseVisualStyleBackColor = true;
            this.btnSystemInfo.Click += new System.EventHandler(this.btnSystemInfo_Click);
            // 
            // btnSmartP
            // 
            this.btnSmartP.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSmartP.FlatAppearance.BorderSize = 0;
            this.btnSmartP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSmartP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSmartP.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSmartP.Image = ((System.Drawing.Image)(resources.GetObject("btnSmartP.Image")));
            this.btnSmartP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSmartP.Location = new System.Drawing.Point(0, 325);
            this.btnSmartP.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnSmartP.Name = "btnSmartP";
            this.btnSmartP.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.btnSmartP.Size = new System.Drawing.Size(241, 60);
            this.btnSmartP.TabIndex = 5;
            this.btnSmartP.Text = "     Adaptive Performance";
            this.btnSmartP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSmartP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSmartP.UseVisualStyleBackColor = true;
            this.btnSmartP.Click += new System.EventHandler(this.btnSmartP_Click);
            // 
            // btnSmartB
            // 
            this.btnSmartB.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSmartB.FlatAppearance.BorderSize = 0;
            this.btnSmartB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSmartB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSmartB.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSmartB.Image = ((System.Drawing.Image)(resources.GetObject("btnSmartB.Image")));
            this.btnSmartB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSmartB.Location = new System.Drawing.Point(0, 265);
            this.btnSmartB.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnSmartB.Name = "btnSmartB";
            this.btnSmartB.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.btnSmartB.Size = new System.Drawing.Size(241, 60);
            this.btnSmartB.TabIndex = 4;
            this.btnSmartB.Text = "     Adaptive ECO";
            this.btnSmartB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSmartB.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSmartB.UseVisualStyleBackColor = true;
            this.btnSmartB.Click += new System.EventHandler(this.btnSmartB_Click);
            // 
            // btnCPresets
            // 
            this.btnCPresets.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCPresets.FlatAppearance.BorderSize = 0;
            this.btnCPresets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCPresets.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCPresets.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCPresets.Image = ((System.Drawing.Image)(resources.GetObject("btnCPresets.Image")));
            this.btnCPresets.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCPresets.Location = new System.Drawing.Point(0, 205);
            this.btnCPresets.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnCPresets.Name = "btnCPresets";
            this.btnCPresets.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.btnCPresets.Size = new System.Drawing.Size(241, 60);
            this.btnCPresets.TabIndex = 3;
            this.btnCPresets.Text = "     Custom Presets";
            this.btnCPresets.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCPresets.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCPresets.UseVisualStyleBackColor = true;
            this.btnCPresets.Click += new System.EventHandler(this.btnCPresets_Click);
            // 
            // btnPPresets
            // 
            this.btnPPresets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnPPresets.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPPresets.FlatAppearance.BorderSize = 0;
            this.btnPPresets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPPresets.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPPresets.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnPPresets.Image = ((System.Drawing.Image)(resources.GetObject("btnPPresets.Image")));
            this.btnPPresets.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPPresets.Location = new System.Drawing.Point(0, 145);
            this.btnPPresets.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnPPresets.Name = "btnPPresets";
            this.btnPPresets.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.btnPPresets.Size = new System.Drawing.Size(241, 60);
            this.btnPPresets.TabIndex = 2;
            this.btnPPresets.Text = "     Pre-Made Presets";
            this.btnPPresets.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPPresets.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPPresets.UseVisualStyleBackColor = false;
            this.btnPPresets.Click += new System.EventHandler(this.btnPPresets_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(166)))));
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.6F);
            this.btnHome.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(0, 85);
            this.btnHome.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.btnHome.Size = new System.Drawing.Size(241, 60);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "     Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(106)))));
            this.panelLogo.Controls.Add(this.lblEd);
            this.panelLogo.Controls.Add(this.label1);
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(241, 85);
            this.panelLogo.TabIndex = 0;
            this.panelLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelLogo_MouseDown);
            // 
            // lblEd
            // 
            this.lblEd.AutoSize = true;
            this.lblEd.BackColor = System.Drawing.Color.Transparent;
            this.lblEd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblEd.ForeColor = System.Drawing.Color.White;
            this.lblEd.Location = new System.Drawing.Point(119, 57);
            this.lblEd.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblEd.Name = "lblEd";
            this.lblEd.Size = new System.Drawing.Size(85, 24);
            this.lblEd.TabIndex = 2;
            this.lblEd.Text = "Standard";
            this.lblEd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(80, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "AMD APU\r\nTuning Utility\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelLogo_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelLogo_MouseDown);
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.BackColor = System.Drawing.Color.Transparent;
            this.lblVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblVersion.Location = new System.Drawing.Point(781, 52);
            this.lblVersion.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(86, 16);
            this.lblVersion.TabIndex = 2;
            this.lblVersion.Text = "2.0.5.5 Stable";
            this.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblVersion.Visible = false;
            this.lblVersion.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelLogo_MouseDown);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(166)))));
            this.panelTitleBar.Controls.Add(this.btnPE);
            this.panelTitleBar.Controls.Add(this.lblVersion);
            this.panelTitleBar.Controls.Add(this.lblAPU);
            this.panelTitleBar.Controls.Add(this.btnMinimise);
            this.panelTitleBar.Controls.Add(this.btnMaximise);
            this.panelTitleBar.Controls.Add(this.btnClose);
            this.panelTitleBar.Controls.Add(this.lblTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(258, 0);
            this.panelTitleBar.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(887, 85);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // btnPE
            // 
            this.btnPE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPE.BackColor = System.Drawing.Color.Transparent;
            this.btnPE.FlatAppearance.BorderSize = 0;
            this.btnPE.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnPE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnPE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPE.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPE.ForeColor = System.Drawing.Color.White;
            this.btnPE.Location = new System.Drawing.Point(619, 0);
            this.btnPE.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnPE.Name = "btnPE";
            this.btnPE.Size = new System.Drawing.Size(151, 34);
            this.btnPE.TabIndex = 7;
            this.btnPE.Text = "Project Snowdrop";
            this.btnPE.UseVisualStyleBackColor = false;
            this.btnPE.Visible = false;
            this.btnPE.Click += new System.EventHandler(this.btnPE_Click);
            // 
            // lblAPU
            // 
            this.lblAPU.AutoSize = true;
            this.lblAPU.BackColor = System.Drawing.Color.Transparent;
            this.lblAPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAPU.ForeColor = System.Drawing.Color.White;
            this.lblAPU.Location = new System.Drawing.Point(5, 61);
            this.lblAPU.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblAPU.Name = "lblAPU";
            this.lblAPU.Size = new System.Drawing.Size(101, 16);
            this.lblAPU.TabIndex = 5;
            this.lblAPU.Text = "APU: (unknown)";
            this.lblAPU.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAPU.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // btnMinimise
            // 
            this.btnMinimise.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimise.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimise.FlatAppearance.BorderSize = 0;
            this.btnMinimise.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimise.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimise.ForeColor = System.Drawing.Color.White;
            this.btnMinimise.Location = new System.Drawing.Point(780, 0);
            this.btnMinimise.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnMinimise.Name = "btnMinimise";
            this.btnMinimise.Size = new System.Drawing.Size(35, 34);
            this.btnMinimise.TabIndex = 3;
            this.btnMinimise.Text = "_";
            this.btnMinimise.UseVisualStyleBackColor = false;
            this.btnMinimise.Click += new System.EventHandler(this.btnMinimise_Click);
            // 
            // btnMaximise
            // 
            this.btnMaximise.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximise.BackColor = System.Drawing.Color.Transparent;
            this.btnMaximise.FlatAppearance.BorderSize = 0;
            this.btnMaximise.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximise.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaximise.ForeColor = System.Drawing.Color.White;
            this.btnMaximise.Location = new System.Drawing.Point(814, 0);
            this.btnMaximise.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnMaximise.Name = "btnMaximise";
            this.btnMaximise.Size = new System.Drawing.Size(35, 34);
            this.btnMaximise.TabIndex = 2;
            this.btnMaximise.Text = "□";
            this.btnMaximise.UseVisualStyleBackColor = false;
            this.btnMaximise.Click += new System.EventHandler(this.btnMaximise_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(851, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 34);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(263, 21);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(348, 47);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Home";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // ThemeMain
            // 
            this.ThemeMain.Enabled = true;
            this.ThemeMain.Interval = 500;
            this.ThemeMain.Tick += new System.EventHandler(this.ThemeMain_Tick);
            // 
            // panelControl
            // 
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl.Location = new System.Drawing.Point(0, 0);
            this.panelControl.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(887, 541);
            this.panelControl.TabIndex = 0;
            // 
            // panelContainer
            // 
            this.panelContainer.Controls.Add(this.panelControl);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(258, 85);
            this.panelContainer.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(887, 541);
            this.panelContainer.TabIndex = 2;
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "AATU";
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // FormOpacity
            // 
            this.FormOpacity.Interval = 25;
            this.FormOpacity.Tick += new System.EventHandler(this.FormOpacity_Tick);
            // 
            // AutoReapply
            // 
            this.AutoReapply.Enabled = true;
            this.AutoReapply.Interval = 2500;
            this.AutoReapply.Tick += new System.EventHandler(this.AutoReapply_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1145, 626);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Form1";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AMD APU Tuning Utility";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.panelContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnSystemInfo;
        private System.Windows.Forms.Button btnSmartP;
        private System.Windows.Forms.Button btnSmartB;
        private System.Windows.Forms.Button btnCPresets;
        private System.Windows.Forms.Button btnPPresets;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnMinimise;
        private System.Windows.Forms.Button btnMaximise;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Timer ThemeMain;
        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Label lblAPU;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnROG;
        public System.Windows.Forms.NotifyIcon notifyIcon;
        private Timer FormOpacity;
        private Timer AutoReapply;
        private Button btnGPU;
        private Button btnPE;
        private Label lblEd;
        private Button btnCPUOC;
    }
}

