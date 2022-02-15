using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using AMD_APU_Tuning_Utility.Properties;
using System.Management;
using DiscordRPC;
using System.Diagnostics;
using System.Net.NetworkInformation;
using System.Threading;
using Button = DiscordRPC.Button;

namespace AMD_APU_Tuning_Utility
{
    public partial class Form1 : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );

        // Fields
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        //Variables
        bool useDefaultTheme = (bool)Settings.Default["useDefaultTheme"];

        int topBar1 = 0;
        int topBar2 = 180;
        int topBar3 = 166;

        int sideBar1 = 0;
        int sideBar2 = 110;
        int sideBar3 = 106;
        double i = 0;

        string CPUName = "";
        string series = "";
        string path = (string)Settings.Default["Path"];
        string path4;
        string path5;

        PrivateFontCollection pfc = new PrivateFontCollection();

        public DiscordRpcClient client;
        //MessageBox.Show(path);

        bool discord = (bool)Settings.Default["Discord"];
        bool tray = (bool)Settings.Default["Tray"];

        public Form1()
        {
            InitializeComponent();

            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 14, 14));
            

            if (tray == true)
            {
                this.WindowState = FormWindowState.Minimized;
                this.Hide();
                notifyIcon.Visible = true;
            }
            //panelMenu.Controls.SetChildIndex(btnSettings, 0); 
           panelMenu.Controls.SetChildIndex(btnGPU, 5);
        }



        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();


        private void Form1_Load(object sender, EventArgs e)
        {
            this.Opacity = 0;
            path = path + "\\eurofighter.ttf";
            Settings.Default["aatuVersion"] = lblVersion.Text;
            Settings.Default.Save();
            
            pfc.AddFontFile(path);
            label1.Font = new Font(pfc.Families[0], 13);
            lblEd.Font = new Font(pfc.Families[0], 11);
            /*
                        if (!Directory.Exists((string)Settings.Default["Path"] + "//ps-config"))
                        {
                            btnPE.Visible = false;
                        }
                        else
                        {
                            btnPE.Visible = true;
                        }*/


            this.findCPU();
            this.setDiscord();

            //Form1.SetProcessDPIAware();


            //Checking Theme settings
            if (!useDefaultTheme)
            {
                topBar1 = (int)Settings.Default["topBar1"];
                topBar2 = (int)Settings.Default["topBar2"];
                topBar3 = (int)Settings.Default["topBar3"];

                sideBar1 = (int)Settings.Default["sideBar1"];
                sideBar2 = (int)Settings.Default["sideBar2"];
                sideBar3 = (int)Settings.Default["sideBar3"];
            }
            else
            {
                topBar1 = 0;
                topBar2 = 180;
                topBar3 = 166;

                sideBar1 = 0;
                sideBar2 = 110;
                sideBar3 = 106;
            }





            //lblAPU.Text = "APU: Apple M1 (8 Cores 8 Threads @ 3.2GHz/3.0GHz)";
            //lblAPU.Text = "APU: Ryzen 9 5980HX (8 Cores 16 Threads @ 4.8GHz/3.3GHz)";
            lblTitle.Text = "Home";
            btnHome.BackColor = Color.FromArgb(topBar1, topBar2, topBar3);
            btnHome.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Regular);
            panelTitleBar.BackColor = Color.FromArgb(topBar1, topBar2, topBar3);
            panelLogo.BackColor = Color.FromArgb(sideBar1, sideBar2, sideBar3);


            btnCPresets.BackColor = Color.FromArgb(51, 51, 76);
            btnPPresets.BackColor = Color.FromArgb(51, 51, 76);
            btnSettings.BackColor = Color.FromArgb(51, 51, 76);
            btnSmartB.BackColor = Color.FromArgb(51, 51, 76);
            btnSmartP.BackColor = Color.FromArgb(51, 51, 76);
            btnSystemInfo.BackColor = Color.FromArgb(51, 51, 76);
            btnGPU.BackColor = Color.FromArgb(51, 51, 76);

            btnGPU.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
            btnSystemInfo.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
            btnCPresets.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
            btnPPresets.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
            btnSettings.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
            btnSmartB.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
            btnSmartP.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);









            panelControl.Controls.Clear();
            panelControl.Controls.Add(HomeMenu.Instance);
            HomeMenu.Instance.Dock = DockStyle.Fill;

            bool ac = (bool)Settings.Default["AC"];
            if (ac == true)
            {
                btnROG.Visible = true;
            }
            else
            {
                btnROG.Visible = false;
            }

            FormOpacity.Enabled = true;

            string mbo = "";
            ManagementObjectSearcher baseboardSearcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_BaseBoard");
            foreach (ManagementObject queryObj in baseboardSearcher.Get())
            {
                mbo = queryObj["Manufacturer"].ToString();
                mbo = mbo.ToLower();
            }

            if (mbo.Contains("aya") && this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;

                Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 0, 0));
            }

        }


        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);

            }
        }



        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximise_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;

                Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 14, 14));
            }
            else
            {
                this.WindowState = FormWindowState.Maximized; ;

                Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 0, 0));
            }
        }

        private void btnMinimise_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panelLogo_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);

            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            CheckColour();
            lblTitle.Text = "Home";
            btnHome.BackColor = Color.FromArgb(topBar1, topBar2, topBar3);
            btnHome.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Regular);
            panelTitleBar.BackColor = Color.FromArgb(topBar1, topBar2, topBar3);
            panelLogo.BackColor = Color.FromArgb(sideBar1, sideBar2, sideBar3);


            btnCPresets.BackColor = Color.FromArgb(51, 51, 76);
            btnPPresets.BackColor = Color.FromArgb(51, 51, 76);
            btnSettings.BackColor = Color.FromArgb(51, 51, 76);
            btnSmartB.BackColor = Color.FromArgb(51, 51, 76);
            btnSmartP.BackColor = Color.FromArgb(51, 51, 76);
            btnSystemInfo.BackColor = Color.FromArgb(51, 51, 76);
            btnROG.BackColor = Color.FromArgb(51, 51, 76);
            btnGPU.BackColor = Color.FromArgb(51, 51, 76);

            btnGPU.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
            btnSystemInfo.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
            btnCPresets.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
            btnPPresets.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
            btnSettings.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
            btnSmartB.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
            btnSmartP.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
            btnROG.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);








            panelControl.Controls.Clear();
            panelControl.Controls.Add(HomeMenu.Instance);
            HomeMenu.Instance.Dock = DockStyle.Fill;
        }

        private void btnCPresets_Click(object sender, EventArgs e)
        {
            CheckColour();
            lblTitle.Text = "Custom Presets";

            btnCPresets.BackColor = Color.FromArgb(topBar1, topBar2, topBar3);
            btnCPresets.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Regular);
            panelTitleBar.BackColor = Color.FromArgb(topBar1, topBar2, topBar3);
            panelLogo.BackColor = Color.FromArgb(sideBar1, sideBar2, sideBar3);


            btnHome.BackColor = Color.FromArgb(51, 51, 76);
            btnPPresets.BackColor = Color.FromArgb(51, 51, 76);
            btnSettings.BackColor = Color.FromArgb(51, 51, 76);
            btnSmartB.BackColor = Color.FromArgb(51, 51, 76);
            btnSmartP.BackColor = Color.FromArgb(51, 51, 76);
            btnSystemInfo.BackColor = Color.FromArgb(51, 51, 76);
            btnROG.BackColor = Color.FromArgb(51, 51, 76);
            btnGPU.BackColor = Color.FromArgb(51, 51, 76);

            btnGPU.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
            btnSystemInfo.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
            btnHome.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
            btnPPresets.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
            btnSettings.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
            btnSmartB.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
            btnSmartP.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
            btnROG.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);








            panelControl.Controls.Clear();
            panelControl.Controls.Add(CustomPresets.Instance);
            CustomPresets.Instance.Dock = DockStyle.Fill;
        }

        private void btnPPresets_Click(object sender, EventArgs e)
        {
            CheckColour();
            lblTitle.Text = "Pre-Made Presets";

            btnPPresets.BackColor = Color.FromArgb(topBar1, topBar2, topBar3);
            btnPPresets.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Regular);
            panelTitleBar.BackColor = Color.FromArgb(topBar1, topBar2, topBar3);
            panelLogo.BackColor = Color.FromArgb(sideBar1, sideBar2, sideBar3);


            btnHome.BackColor = Color.FromArgb(51, 51, 76);
            btnCPresets.BackColor = Color.FromArgb(51, 51, 76);
            btnSettings.BackColor = Color.FromArgb(51, 51, 76);
            btnSmartB.BackColor = Color.FromArgb(51, 51, 76);
            btnSmartP.BackColor = Color.FromArgb(51, 51, 76);
            btnSystemInfo.BackColor = Color.FromArgb(51, 51, 76);
            btnROG.BackColor = Color.FromArgb(51, 51, 76);
            btnGPU.BackColor = Color.FromArgb(51, 51, 76);

            btnGPU.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
            btnSystemInfo.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
            btnHome.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
            btnCPresets.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
            btnSettings.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
            btnSmartB.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
            btnSmartP.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
            btnROG.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);








            panelControl.Controls.Clear();
            panelControl.Controls.Add(PremadePresets.Instance);
            PremadePresets.Instance.Dock = DockStyle.Fill;
        }

        private void btnSmartB_Click(object sender, EventArgs e)
        {
            CheckColour();
            lblTitle.Text = "Adaptive ECO";

            btnSmartB.BackColor = Color.FromArgb(topBar1, topBar2, topBar3);
            btnSmartB.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Regular);
            panelTitleBar.BackColor = Color.FromArgb(topBar1, topBar2, topBar3);
            panelLogo.BackColor = Color.FromArgb(sideBar1, sideBar2, sideBar3);


            btnHome.BackColor = Color.FromArgb(51, 51, 76);
            btnCPresets.BackColor = Color.FromArgb(51, 51, 76);
            btnSettings.BackColor = Color.FromArgb(51, 51, 76);
            btnPPresets.BackColor = Color.FromArgb(51, 51, 76);
            btnSmartP.BackColor = Color.FromArgb(51, 51, 76);
            btnROG.BackColor = Color.FromArgb(51, 51, 76);
            btnGPU.BackColor = Color.FromArgb(51, 51, 76);

            btnGPU.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
            btnSystemInfo.BackColor = Color.FromArgb(51, 51, 76);
            btnSystemInfo.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
            btnHome.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
            btnCPresets.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
            btnSettings.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
            btnPPresets.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
            btnSmartP.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
            btnROG.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);








            panelControl.Controls.Clear();
            panelControl.Controls.Add(SBM.Instance);
            SBM.Instance.Dock = DockStyle.Fill;
        }

        private void btnSmartP_Click(object sender, EventArgs e)
        {
            CheckColour();
            lblTitle.Text = "Adaptive Performance";

            btnSmartP.BackColor = Color.FromArgb(topBar1, topBar2, topBar3);
            btnSmartP.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Regular);
            panelTitleBar.BackColor = Color.FromArgb(topBar1, topBar2, topBar3);
            panelLogo.BackColor = Color.FromArgb(sideBar1, sideBar2, sideBar3);


            btnHome.BackColor = Color.FromArgb(51, 51, 76);
            btnCPresets.BackColor = Color.FromArgb(51, 51, 76);
            btnSettings.BackColor = Color.FromArgb(51, 51, 76);
            btnPPresets.BackColor = Color.FromArgb(51, 51, 76);
            btnSmartB.BackColor = Color.FromArgb(51, 51, 76);
            btnSystemInfo.BackColor = Color.FromArgb(51, 51, 76);
            btnROG.BackColor = Color.FromArgb(51, 51, 76);
            btnGPU.BackColor = Color.FromArgb(51, 51, 76);

            btnGPU.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
            btnSystemInfo.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
            btnHome.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
            btnCPresets.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
            btnSettings.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
            btnPPresets.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
            btnSmartB.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
            btnROG.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);








            panelControl.Controls.Clear();
            panelControl.Controls.Add(SPM.Instance);
            SPM.Instance.Dock = DockStyle.Fill;
        }

        private void btnSystemInfo_Click(object sender, EventArgs e)
        {

            CheckColour();
            lblTitle.Text = "System Info";
            btnSystemInfo.BackColor = Color.FromArgb(topBar1, topBar2, topBar3);
            btnSystemInfo.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Regular);
            panelTitleBar.BackColor = Color.FromArgb(topBar1, topBar2, topBar3);
            panelLogo.BackColor = Color.FromArgb(sideBar1, sideBar2, sideBar3);


            btnHome.BackColor = Color.FromArgb(51, 51, 76);
            btnCPresets.BackColor = Color.FromArgb(51, 51, 76);
            btnSmartP.BackColor = Color.FromArgb(51, 51, 76);
            btnPPresets.BackColor = Color.FromArgb(51, 51, 76);
            btnSmartB.BackColor = Color.FromArgb(51, 51, 76);
            btnSettings.BackColor = Color.FromArgb(51, 51, 76);
            btnROG.BackColor = Color.FromArgb(51, 51, 76);
            btnGPU.BackColor = Color.FromArgb(51, 51, 76);

            btnGPU.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
            btnHome.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
            btnCPresets.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
            btnSmartP.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
            btnPPresets.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
            btnSmartB.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
            btnSettings.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
            btnROG.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);








            panelControl.Controls.Clear();
            panelControl.Controls.Add(SysInfo.Instance);
            SysInfo.Instance.Dock = DockStyle.Fill;
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            CheckColour();
            lblTitle.Text = "Settings";
            btnSettings.BackColor = Color.FromArgb(topBar1, topBar2, topBar3);
            btnSettings.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Regular);
            panelTitleBar.BackColor = Color.FromArgb(topBar1, topBar2, topBar3);
            panelLogo.BackColor = Color.FromArgb(sideBar1, sideBar2, sideBar3);


            btnHome.BackColor = Color.FromArgb(51, 51, 76);
            btnCPresets.BackColor = Color.FromArgb(51, 51, 76);
            btnSmartP.BackColor = Color.FromArgb(51, 51, 76);
            btnPPresets.BackColor = Color.FromArgb(51, 51, 76);
            btnSmartB.BackColor = Color.FromArgb(51, 51, 76);
            btnSystemInfo.BackColor = Color.FromArgb(51, 51, 76);
            btnROG.BackColor = Color.FromArgb(51, 51, 76);
            btnGPU.BackColor = Color.FromArgb(51, 51, 76);

            btnGPU.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
            btnSystemInfo.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
            btnHome.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
            btnCPresets.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
            btnSmartP.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
            btnPPresets.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
            btnSmartB.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
            btnROG.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);







            panelControl.Controls.Clear();
            panelControl.Controls.Add(SettingsMenu.Instance);
            SettingsMenu.Instance.Dock = DockStyle.Fill;
        }
        private void btnROG_Click(object sender, EventArgs e)
        {
            CheckColour();
            lblTitle.Text = "ROG Armoury Crate Modes";
            btnROG.BackColor = Color.FromArgb(topBar1, topBar2, topBar3);
            btnROG.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Regular);
            panelTitleBar.BackColor = Color.FromArgb(topBar1, topBar2, topBar3);
            panelLogo.BackColor = Color.FromArgb(sideBar1, sideBar2, sideBar3);


            btnHome.BackColor = Color.FromArgb(51, 51, 76);
            btnCPresets.BackColor = Color.FromArgb(51, 51, 76);
            btnSmartP.BackColor = Color.FromArgb(51, 51, 76);
            btnPPresets.BackColor = Color.FromArgb(51, 51, 76);
            btnSmartB.BackColor = Color.FromArgb(51, 51, 76);
            btnSystemInfo.BackColor = Color.FromArgb(51, 51, 76);
            btnSettings.BackColor = Color.FromArgb(51, 51, 76);
            btnGPU.BackColor = Color.FromArgb(51, 51, 76);

            btnGPU.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
            btnSystemInfo.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
            btnHome.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
            btnCPresets.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
            btnSmartP.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
            btnPPresets.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
            btnSmartB.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
            btnSettings.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);

            panelControl.Controls.Clear();
            panelControl.Controls.Add(ROG.Instance);
            ROG.Instance.Dock = DockStyle.Fill;
        }

        public void CheckColour()
        {
            if (!useDefaultTheme)
            {
                topBar1 = (int)Settings.Default["topBar1"];
                topBar2 = (int)Settings.Default["topBar2"];
                topBar3 = (int)Settings.Default["topBar3"];

                sideBar1 = (int)Settings.Default["sideBar1"];
                sideBar2 = (int)Settings.Default["sideBar2"];
                sideBar3 = (int)Settings.Default["sideBar3"];
            }
            else
            {
                topBar1 = 0;
                topBar2 = 180;
                topBar3 = 166;

                sideBar1 = 0;
                sideBar2 = 110;
                sideBar3 = 106;
            }
        }

        [DllImport("psapi.dll")]
        static extern int EmptyWorkingSet(IntPtr hwProc);

        static void MinimizeFootprint()
        {
            EmptyWorkingSet(Process.GetCurrentProcess().Handle);
        }

        private void ThemeMain_Tick(object sender, EventArgs e)
        {
            /*
            try
            {
                Ping myPing = new Ping();
                String host = "chipsandcheese.com";
                byte[] buffer = new byte[512];
                int timeout = 100;
                PingOptions pingOptions = new PingOptions();
                PingReply reply = myPing.Send(host, timeout, buffer, pingOptions);
            }
            catch (Exception)
            {
                Application.Exit();
            }
            */
            MinimizeFootprint();
            Thread.Sleep(1);

            long usedMemory = GC.GetTotalMemory(true);

            this.MaximumSize = Screen.PrimaryScreen.WorkingArea.Size;
            tray = (bool)Settings.Default["Tray"];

            useDefaultTheme = (bool)Settings.Default["useDefaultTheme"];

            if (!useDefaultTheme)
            {
                topBar1 = (int)Settings.Default["topBar1"];
                topBar2 = (int)Settings.Default["topBar2"];
                topBar3 = (int)Settings.Default["topBar3"];

                sideBar1 = (int)Settings.Default["sideBar1"];
                sideBar2 = (int)Settings.Default["sideBar2"];
                sideBar3 = (int)Settings.Default["sideBar3"];



            }
            else
            {
                topBar1 = 0;
                topBar2 = 180;
                topBar3 = 166;

                sideBar1 = 0;
                sideBar2 = 110;
                sideBar3 = 106;
            }


            if (lblTitle.Text == "Home")
            {
                btnHome.BackColor = Color.FromArgb(topBar1, topBar2, topBar3);
                panelTitleBar.BackColor = Color.FromArgb(topBar1, topBar2, topBar3);
                panelLogo.BackColor = Color.FromArgb(sideBar1, sideBar2, sideBar3);


            }
            else if (lblTitle.Text == "Pre-Made Presets")
            {
                btnPPresets.BackColor = Color.FromArgb(topBar1, topBar2, topBar3);
                panelTitleBar.BackColor = Color.FromArgb(topBar1, topBar2, topBar3);
                panelLogo.BackColor = Color.FromArgb(sideBar1, sideBar2, sideBar3);

            }
            else if (lblTitle.Text == "Custom Presets")
            {
                btnCPresets.BackColor = Color.FromArgb(topBar1, topBar2, topBar3);

                panelTitleBar.BackColor = Color.FromArgb(topBar1, topBar2, topBar3);
                panelLogo.BackColor = Color.FromArgb(sideBar1, sideBar2, sideBar3);
            }
            else if (lblTitle.Text == "System Info")
            {
                btnSystemInfo.BackColor = Color.FromArgb(topBar1, topBar2, topBar3);

                panelTitleBar.BackColor = Color.FromArgb(topBar1, topBar2, topBar3);
                panelLogo.BackColor = Color.FromArgb(sideBar1, sideBar2, sideBar3);
            }
            else if (lblTitle.Text == "Settings")
            {
                btnSettings.BackColor = Color.FromArgb(topBar1, topBar2, topBar3);

                panelTitleBar.BackColor = Color.FromArgb(topBar1, topBar2, topBar3);
                panelLogo.BackColor = Color.FromArgb(sideBar1, sideBar2, sideBar3);
            }
            else if (lblTitle.Text == "GPU Overclocking")
            {
                btnGPU.BackColor = Color.FromArgb(topBar1, topBar2, topBar3);

                panelTitleBar.BackColor = Color.FromArgb(topBar1, topBar2, topBar3);
                panelLogo.BackColor = Color.FromArgb(sideBar1, sideBar2, sideBar3);
            }

            bool ac = (bool)Settings.Default["AC"];
            if (ac == true)
            {
                btnROG.Visible = true;
            }
            else
            {
                btnROG.Visible = false;
            }

        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon.Visible = false;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (tray == true)
            {
                if (this.WindowState == FormWindowState.Minimized)
                {
                    Hide();
                    notifyIcon.Visible = true;
                }
            }
        }

        

        private void findCPU()
        {
            //Get CPU name
            ManagementObjectSearcher myProcessorObject = new ManagementObjectSearcher("select * from Win32_Processor");
            foreach (ManagementObject obj in myProcessorObject.Get())
            {
                CPUName = obj["Name"].ToString();
            }

            //Setting CPU Name
            if (CPUName.Contains("5900HS"))
            {
                CPUName = "Ryzen 9 5900HS";
                series = "5000";
                lblAPU.Text = "APU: Ryzen 9 5900HS (8 Cores 16 Threads @ 4.6GHz/3.0GHz)";
            }
            else if (CPUName.Contains("5980HS"))
            {
                CPUName = "Ryzen 9 5980HS";
                series = "5000";
                lblAPU.Text = "APU: Ryzen 9 5980HS (8 Cores 16 Threads @ 4.8GHz/3.0GHz)";
            }
            else if (CPUName.Contains("5800HS"))
            {
                CPUName = "Ryzen 7 5800HS";
                series = "5000";
                lblAPU.Text = "APU: Ryzen 7 5800HS (8 Cores 16 Threads @ 4.4GHz/2.8GHz)";
            }
            else if (CPUName.Contains("5600HS"))
            {
                CPUName = "Ryzen 5 5600HS";
                series = "5000";
                lblAPU.Text = "APU: Ryzen 5 5600HS (6 Cores 12 Threads @ 4.2GHz/3.0GHz)";
            }
            else if (CPUName.Contains("5900HX"))
            {
                CPUName = "Ryzen 9 5900HX";
                lblAPU.Text = "APU: Ryzen 9 5900HX (8 Cores 16 Threads @ 4.6GHz/3.3GHz)";
            }
            else if (CPUName.Contains("5980HX"))
            {
                CPUName = "Ryzen 9 5980HX";
                series = "5000";
                lblAPU.Text = "APU: Ryzen 9 5980HX (8 Cores 16 Threads @ 4.8GHz/3.3GHz)";
            }
            else if (CPUName.Contains("5800H"))
            {
                CPUName = "Ryzen 7 5800H";
                series = "5000";
                lblAPU.Text = "APU: Ryzen 7 5800H (8 Cores 16 Threads @ 4.4GHz/3.2GHz)";
            }
            else if (CPUName.Contains("5600H"))
            {
                CPUName = "Ryzen 5 5600H";
                series = "5000";
                lblAPU.Text = "APU: Ryzen 5 5600H (6 Cores 12 Threads @ 4.2GHz/3.3GHz)";
            }
            else if (CPUName.Contains("4900HS"))
            {
                CPUName = "Ryzen 9 4900HS";
                lblAPU.Text = "APU: Ryzen 9 4900HS (8 Cores 16 Threads @ 4.3GHz/3.0GHz)";
            }
            else if (CPUName.Contains("4800HS"))
            {
                CPUName = "Ryzen 7 4800HS";
                lblAPU.Text = "APU: Ryzen 7 4800HS (8 Cores 16 Threads @ 4.2GHz/2.9GHz)";
            }
            else if (CPUName.Contains("4600HS"))
            {
                CPUName = "Ryzen 5 4600HS";
                lblAPU.Text = "APU: Ryzen 5 4600HS (6 Cores 12 Threads @ 4GHz/3GHz)";
            }
            else if (CPUName.Contains("4900H"))
            {
                CPUName = "Ryzen 9 4900H";
                lblAPU.Text = "APU: Ryzen 9 4900H (8 Cores 16 Threads @ 4.4GHz/3.3GHz)";
            }
            else if (CPUName.Contains("4800H"))
            {
                CPUName = "Ryzen 7 4800H";
                lblAPU.Text = "APU: Ryzen 7 4800H (8 Cores 16 Threads @ 4.2GHz/2.9GHz)";
            }
            else if (CPUName.Contains("4600H"))
            {
                CPUName = "Ryzen 5 4600H";
                lblAPU.Text = "APU: Ryzen 5 4600H (6 Cores 12 Threads @ 4GHz/3GHz)";
            }
            else if (CPUName.Contains("3750H"))
            {
                CPUName = "Ryzen 7 3750H";
                lblAPU.Text = "APU: Ryzen 7 3750H (4 Cores 8 Threads @ 4GHz/2.3GHz)";
            }
            else if (CPUName.Contains("3550H"))
            {
                CPUName = "Ryzen 5 3550H";
                lblAPU.Text = "APU: Ryzen 5 3550H (4 Cores 8 Threads @ 3.7GHz/2.1GHz)";
            }
            else if (CPUName.Contains("5800U"))
            {
                CPUName = "Ryzen 7 5800U";
                series = "5000";
                lblAPU.Text = "APU: Ryzen 7 5800U (8 Cores 16 Threads @ 4.4GHz/1.9GHz)";
            }
            else if (CPUName.Contains("5700U"))
            {
                CPUName = "Ryzen 7 5700U";
                series = "5000";
                lblAPU.Text = "APU: Ryzen 7 5700U (8 Cores 16 Threads @ 4.3GHz/1.8GHz)";
            }
            else if (CPUName.Contains("5600U"))
            {
                CPUName = "Ryzen 5 5600U";
                series = "5000";
                lblAPU.Text = "APU: Ryzen 5 5600U (6 Cores 12 Threads @ 4.2GHz/2.3GHz)";
            }
            else if (CPUName.Contains("5500U"))
            {
                CPUName = "Ryzen 5 5500U";
                series = "5000";
                lblAPU.Text = "APU: Ryzen 5 5500U (6 Cores 12 Threads @ 4GHz/2.1GHz)";
            }
            else if (CPUName.Contains("4800U"))
            {
                CPUName = "Ryzen 7 4800U";
                lblAPU.Text = "APU: Ryzen 7 4800U (8 Cores 16 Threads @ 4.2GHz/1.8GHz)";
            }
            else if (CPUName.Contains("4700U"))
            {
                CPUName = "Ryzen 7 4700U";
                lblAPU.Text = "APU: Ryzen 7 4700U (8 Cores 8 Threads @ 4.1GHz/2GHz)";
            }
            else if (CPUName.Contains("4600U"))
            {
                CPUName = "Ryzen 5 4600U";
                lblAPU.Text = "APU: Ryzen 5 4600U (6 Cores 12 Threads @ 4GHz/2.1GHz)";
            }
            else if (CPUName.Contains("4500U"))
            {
                CPUName = "Ryzen 5 4500U";
                lblAPU.Text = "APU: Ryzen 5 4500U (6 Cores 6 Threads @ 4GHz/2.3GHz)";
            }
            else if (CPUName.Contains("4300U"))
            {
                CPUName = "Ryzen 3 4300U";
                lblAPU.Text = "APU: Ryzen 3 4300U (4 Cores 4 Threads @ 3.7GHz/2.GHz)";
            }
            else if (CPUName.Contains("3700U"))
            {
                CPUName = "Ryzen 7 3700U";
                lblAPU.Text = "APU: Ryzen 7 3700U (4 Cores 8 Threads @ 4GHz/2.3GHz)";
            }
            else if (CPUName.Contains("3500U"))
            {
                CPUName = "Ryzen 5 3500U";
                lblAPU.Text = "APU: Ryzen 5 3500U (4 Cores 8 Threads @ 3.7GHz/2.1GHz)";
            }
            else if (CPUName.Contains("3300U"))
            {
                CPUName = "Ryzen 3 3300U";
                lblAPU.Text = "APU: Ryzen 3 3300U (4 Cores 4 Threads @ 3.5GHz/2.1GHz)";
            }
            else if (CPUName.Contains("3200U"))
            {
                CPUName = "Ryzen 3 3200U";
                lblAPU.Text = "APU: Ryzen 3 3200U (2 Cores 4 Threads @ 3.5GHz/2.6GHz)";
            }
            else if (CPUName.Contains("3700U"))
            {
                CPUName = "Ryzen 7 2700U";
                lblAPU.Text = "APU: Ryzen 7 2700U (4 Cores 8 Threads @ 3.8GHz/2.2GHz)";
            }
            else if (CPUName.Contains("3500U"))
            {
                CPUName = "Ryzen 5 2500U";
                lblAPU.Text = "APU: Ryzen 5 2500U (4 Cores 8 Threads @ 3.6GHz/2GHz)";
            }
            else if (CPUName.Contains("2300U"))
            {
                CPUName = "Ryzen 3 2300U";
                lblAPU.Text = "APU: Ryzen 3 2300U (4 Cores 4 Threads @ 3.4GHz/2GHz)";
            }
            else if (CPUName.Contains("2200U"))
            {
                CPUName = "Ryzen 3 2200U";
                lblAPU.Text = "APU: Ryzen 3 2200U (2 Cores 4 Threads @ 3.4GHz/2.5GHz)";
            }
            else if (CPUName.Contains("6900HS"))
            {
                CPUName = "Ryzen 9 6900HS";
                series = "6000";
                lblAPU.Text = "APU: Ryzen 9 6900HS (8 Cores 16 Threads @ TBA/TBA)";
            }
            else if (CPUName.Contains("6980HS"))
            {
                CPUName = "Ryzen 9 6980HS";
                series = "6000";
                lblAPU.Text = "APU: Ryzen 9 6980HS (8 Cores 16 Threads @ TBA/TBA)";
            }
            else if (CPUName.Contains("5800HS"))
            {
                CPUName = "Ryzen 7 6800HS";
                series = "6000";
                lblAPU.Text = "APU: Ryzen 7 6800HS (8 Cores 16 Threads @ TBA/TBA)";
            }
            else if (CPUName.Contains("6600HS"))
            {
                CPUName = "Ryzen 5 6600HS";
                series = "6000";
                lblAPU.Text = "APU: Ryzen 5 6600HS (6 Cores 12 Threads @ TBA/TBA)";
            }
            else if (CPUName.Contains("6900HX"))
            {
                CPUName = "Ryzen 9 6900HX";
                series = "6000";
                lblAPU.Text = "APU: Ryzen 9 6900HX (8 Cores 16 Threads @ TBA/TBA)";
            }
            else if (CPUName.Contains("6980HX"))
            {
                CPUName = "Ryzen 9 6980HX";
                series = "6000";
                lblAPU.Text = "APU: Ryzen 9 6980HX (8 Cores 16 Threads @ TBA/TBA)";
            }
            else if (CPUName.Contains("6800H"))
            {
                CPUName = "Ryzen 7 6800H";
                series = "6000";
                lblAPU.Text = "APU: Ryzen 7 6800H (8 Cores 16 Threads @ TBA/TBA)";
            }
            else if (CPUName.Contains("6600H"))
            {
                CPUName = "Ryzen 5 6600H";
                series = "6000";
                lblAPU.Text = "APU: Ryzen 5 6600H (6 Cores 12 Threads @ TBA/TBA)";
            }
            else if (CPUName.Contains("6800U"))
            {
                CPUName = "Ryzen 7 6800U";
                series = "6000";
                lblAPU.Text = "APU: Ryzen 7 6800U (8 Cores 16 Threads @ TBA/TBA)";
            }
            else if (CPUName.Contains("6600U"))
            {
                CPUName = "Ryzen 5 6600U";
                series = "6000";
                lblAPU.Text = "APU: Ryzen 5 6600U (6 Cores 12 Threads @ TBA/TBA)";
            }
            else
            {
                lblAPU.Text = "APU: " + CPUName;
            }

            Settings.Default["Series"] = series;
            Settings.Default["APUName"] = CPUName;
            Settings.Default.Save();
        }

        private void setDiscord()
        {
            if (discord == true)
            {
                client = new DiscordRpcClient("761946503006388224");
                client.SetPresence(new RichPresence()
                {
                    Details = "Version: " + lblVersion.Text,
                    State = $"{CPUName}",
                    Buttons = new Button[]
                    {
                        new Button() { Label = "About AATU", Url = "https://amdaputuningutility.com/" },
                        new Button() { Label = "Download AATU", Url = "https://github.com/JamesCJ60/AMD-APU-Tuning-Utility/releases" }
                    },
                    Assets = new Assets()
                    {
                        LargeImageKey = "newicon"
                    }

                });
                client.Initialize();
            }
        }

        private void Internet_Tick(object sender, EventArgs e)
        {
            Internet();
        }

        public void Internet()
        {
            /*bool connection;
            try
            {
                Ping myPing = new Ping();
                String host = "google.com";
                byte[] buffer = new byte[32];
                int timeout = 1000;
                PingOptions pingOptions = new PingOptions();
                PingReply reply = myPing.Send(host, timeout, buffer, pingOptions);
                connection = true;
            }
            catch (Exception)
            {
                connection = false;
            }*/

            Settings.Default["Internet"] = true;
            Settings.Default.Save();
        }

        public void trayMin()
        {
            if (tray == true)
            {
                this.WindowState = FormWindowState.Minimized;
                this.Hide();
                notifyIcon.Visible = true;
            }
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            if (tray == true)
            {
                this.WindowState = FormWindowState.Minimized;
                this.Hide();
                notifyIcon.Visible = true;
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void FormOpacity_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 0.98 && this.Opacity != 0.98)
            {
                this.Opacity = i;
            }
            else
            {
                this.Opacity = 0.98;
                FormOpacity.Enabled = false;
            }
            i = i + 0.10;
        }

        private async void AutoReapply_Tick(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                if (!lblTitle.Text.Contains("Adaptive"))
                {
                    string RyzenADJ = (string)Settings.Default["RyzenADJ"];
                    path4 = (string)Settings.Default["Path"];
                    path5 = (string)Settings.Default["Path"];
                    path4 = path4 + "\\bin\\";

                    path5 = path5 + "\\bin\\Notification.exe";

                    bool auto = (bool)Settings.Default["AutoApply"];

                    if (auto == true)
                    {
                        if (RyzenADJ == "" || RyzenADJ == null)
                        {
                            return;
                        }
                        else
                        {
                            var processInfo = new ProcessStartInfo("cmd.exe")
                            {
                                CreateNoWindow = true,
                                WindowStyle = ProcessWindowStyle.Hidden,
                                UseShellExecute = false,
                                RedirectStandardError = true,
                                RedirectStandardOutput = true,
                                Arguments = "/C ryzenadj.exe " + RyzenADJ,
                                WorkingDirectory = @path4
                            };
                            Process p = Process.Start(processInfo);
                        }
                    }
                }
            });
        }

        private void btnGPU_Click(object sender, EventArgs e)
        {
            CheckColour();
            lblTitle.Text = "GPU Overclocking";
            btnGPU.BackColor = Color.FromArgb(topBar1, topBar2, topBar3);
            btnGPU.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Regular);
            panelTitleBar.BackColor = Color.FromArgb(topBar1, topBar2, topBar3);
            panelLogo.BackColor = Color.FromArgb(sideBar1, sideBar2, sideBar3);


            btnHome.BackColor = Color.FromArgb(51, 51, 76);
            btnCPresets.BackColor = Color.FromArgb(51, 51, 76);
            btnSmartP.BackColor = Color.FromArgb(51, 51, 76);
            btnPPresets.BackColor = Color.FromArgb(51, 51, 76);
            btnSmartB.BackColor = Color.FromArgb(51, 51, 76);
            btnSystemInfo.BackColor = Color.FromArgb(51, 51, 76);
            btnROG.BackColor = Color.FromArgb(51, 51, 76);
            btnSettings.BackColor = Color.FromArgb(51, 51, 76);

            btnSystemInfo.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
            btnHome.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
            btnCPresets.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
            btnSmartP.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
            btnPPresets.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
            btnSmartB.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
            btnROG.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
            btnSettings.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);






            panelControl.Controls.Clear();
            panelControl.Controls.Add(GPUOC.Instance);
            GPUOC.Instance.Dock = DockStyle.Fill;
        }

        private void btnPE_Click(object sender, EventArgs e)
        {
            CheckColour();
            lblTitle.Text = "Project Snowdrop";

            btnHome.BackColor = Color.FromArgb(51, 51, 76);
            btnCPresets.BackColor = Color.FromArgb(51, 51, 76);
            btnSmartP.BackColor = Color.FromArgb(51, 51, 76);
            btnPPresets.BackColor = Color.FromArgb(51, 51, 76);
            btnSmartB.BackColor = Color.FromArgb(51, 51, 76);
            btnSystemInfo.BackColor = Color.FromArgb(51, 51, 76);
            btnROG.BackColor = Color.FromArgb(51, 51, 76);
            btnSettings.BackColor = Color.FromArgb(51, 51, 76);
            btnGPU.BackColor = Color.FromArgb(51, 51, 76);

            btnGPU.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
            btnSystemInfo.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
            btnHome.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
            btnCPresets.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
            btnSmartP.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
            btnPPresets.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
            btnSmartB.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
            btnROG.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
            btnSettings.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);

            panelControl.Controls.Clear();
            panelControl.Controls.Add(ProjectE.Instance);
            ProjectE.Instance.Dock = DockStyle.Fill;
        }
    }
}
