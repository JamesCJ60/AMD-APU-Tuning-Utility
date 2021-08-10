namespace AMD_APU_Tuning_Utility
{
    partial class HomeMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeMenu));
            this.label1 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnDiscord = new System.Windows.Forms.Button();
            this.btnReleases = new System.Windows.Forms.Button();
            this.btnGitHub = new System.Windows.Forms.Button();
            this.btnReddit = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.Theme = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(286, 92);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to";
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Black;
            this.lblName.Location = new System.Drawing.Point(67, 147);
            this.lblName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(710, 73);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "AMD APU Tuning Utility";
            // 
            // btnDiscord
            // 
            this.btnDiscord.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDiscord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(166)))));
            this.btnDiscord.FlatAppearance.BorderSize = 0;
            this.btnDiscord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiscord.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btnDiscord.ForeColor = System.Drawing.Color.White;
            this.btnDiscord.Image = ((System.Drawing.Image)(resources.GetObject("btnDiscord.Image")));
            this.btnDiscord.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDiscord.Location = new System.Drawing.Point(70, 290);
            this.btnDiscord.Margin = new System.Windows.Forms.Padding(6);
            this.btnDiscord.Name = "btnDiscord";
            this.btnDiscord.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.btnDiscord.Size = new System.Drawing.Size(224, 64);
            this.btnDiscord.TabIndex = 2;
            this.btnDiscord.Text = "     Join our Discord";
            this.btnDiscord.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDiscord.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDiscord.UseVisualStyleBackColor = false;
            this.btnDiscord.Click += new System.EventHandler(this.btnDiscord_Click);
            // 
            // btnReleases
            // 
            this.btnReleases.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReleases.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(166)))));
            this.btnReleases.FlatAppearance.BorderSize = 0;
            this.btnReleases.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReleases.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReleases.ForeColor = System.Drawing.Color.White;
            this.btnReleases.Image = ((System.Drawing.Image)(resources.GetObject("btnReleases.Image")));
            this.btnReleases.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReleases.Location = new System.Drawing.Point(189, 366);
            this.btnReleases.Margin = new System.Windows.Forms.Padding(6);
            this.btnReleases.Name = "btnReleases";
            this.btnReleases.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.btnReleases.Size = new System.Drawing.Size(224, 64);
            this.btnReleases.TabIndex = 3;
            this.btnReleases.Text = "     Latest Releases";
            this.btnReleases.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReleases.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReleases.UseVisualStyleBackColor = false;
            this.btnReleases.Click += new System.EventHandler(this.btnReleases_Click);
            // 
            // btnGitHub
            // 
            this.btnGitHub.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGitHub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(166)))));
            this.btnGitHub.FlatAppearance.BorderSize = 0;
            this.btnGitHub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGitHub.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGitHub.ForeColor = System.Drawing.Color.White;
            this.btnGitHub.Image = ((System.Drawing.Image)(resources.GetObject("btnGitHub.Image")));
            this.btnGitHub.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGitHub.Location = new System.Drawing.Point(425, 366);
            this.btnGitHub.Margin = new System.Windows.Forms.Padding(6);
            this.btnGitHub.Name = "btnGitHub";
            this.btnGitHub.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.btnGitHub.Size = new System.Drawing.Size(224, 64);
            this.btnGitHub.TabIndex = 4;
            this.btnGitHub.Text = "     RyzenADJ GitHub";
            this.btnGitHub.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGitHub.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGitHub.UseVisualStyleBackColor = false;
            this.btnGitHub.Click += new System.EventHandler(this.btnGitHub_Click);
            // 
            // btnReddit
            // 
            this.btnReddit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReddit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(166)))));
            this.btnReddit.FlatAppearance.BorderSize = 0;
            this.btnReddit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReddit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReddit.ForeColor = System.Drawing.Color.White;
            this.btnReddit.Image = ((System.Drawing.Image)(resources.GetObject("btnReddit.Image")));
            this.btnReddit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReddit.Location = new System.Drawing.Point(306, 290);
            this.btnReddit.Margin = new System.Windows.Forms.Padding(6);
            this.btnReddit.Name = "btnReddit";
            this.btnReddit.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.btnReddit.Size = new System.Drawing.Size(224, 64);
            this.btnReddit.TabIndex = 5;
            this.btnReddit.Text = "     Join our Subreddit";
            this.btnReddit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReddit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReddit.UseVisualStyleBackColor = false;
            this.btnReddit.Click += new System.EventHandler(this.btnReddit_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(166)))));
            this.btnHelp.FlatAppearance.BorderSize = 0;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btnHelp.ForeColor = System.Drawing.Color.White;
            this.btnHelp.Image = ((System.Drawing.Image)(resources.GetObject("btnHelp.Image")));
            this.btnHelp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHelp.Location = new System.Drawing.Point(542, 290);
            this.btnHelp.Margin = new System.Windows.Forms.Padding(6);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.btnHelp.Size = new System.Drawing.Size(224, 64);
            this.btnHelp.TabIndex = 6;
            this.btnHelp.Text = "     Help";
            this.btnHelp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHelp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // Theme
            // 
            this.Theme.Enabled = true;
            this.Theme.Interval = 500;
            this.Theme.Tick += new System.EventHandler(this.Theme_Tick);
            // 
            // HomeMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnReddit);
            this.Controls.Add(this.btnGitHub);
            this.Controls.Add(this.btnReleases);
            this.Controls.Add(this.btnDiscord);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "HomeMenu";
            this.Size = new System.Drawing.Size(842, 509);
            this.Load += new System.EventHandler(this.HomeMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnDiscord;
        private System.Windows.Forms.Button btnReleases;
        private System.Windows.Forms.Button btnGitHub;
        private System.Windows.Forms.Button btnReddit;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Timer Theme;
    }
}
