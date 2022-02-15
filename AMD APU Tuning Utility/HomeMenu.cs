using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Text;
using System.Drawing.Drawing2D;
using AMD_APU_Tuning_Utility.Properties;
using System.Diagnostics;

namespace AMD_APU_Tuning_Utility
{
    public partial class HomeMenu : UserControl
    {
        public static HomeMenu _instance;
        public static HomeMenu Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new HomeMenu();
                return _instance;
            }
        }

        bool useDefaultTheme = (bool)Settings.Default["useDefaultTheme"];
        int topBar1 = 0;
        int topBar2 = 180;
        int topBar3 = 166;

        int sideBar1 = 0;
        int sideBar2 = 110;
        int sideBar3 = 106;
        int i = 0;

        string RyzenADJ = (string)Settings.Default["RyzenADJ"];
        bool startUp = (bool)Settings.Default["Startup"];
        bool tray = (bool)Settings.Default["Tray"];
        string path = (string)Settings.Default["Path"];
        string path2 = (string)Settings.Default["Path"];
        string path3 = (string)Settings.Default["Path"];
        string path4 = (string)Settings.Default["Path"];
        string path5 = (string)Settings.Default["Path"];

        string args = (string)Settings.Default["Args"];
        string pathAC = (string)Settings.Default["Path"];
        bool ac = (bool)Settings.Default["AC"];

        PrivateFontCollection pfc = new PrivateFontCollection();
        public HomeMenu()
        {
            InitializeComponent();
        }

        private void HomeMenu_Load(object sender, EventArgs e)
        {
            path4 = path4 + "\\version.txt";
            var lines = File.ReadAllLines(path4);
            lblVersion.Text = "Collective Version: " + (string)Settings.Default["aatuVersion"] + "\nApplication Version: " + lines[0] + "\nCreated by JamesCJ, Credits to the RyzenADJ team";

            /*pfc.AddFontFile("eurofighter.ttf");
            lblName.Font = new Font(pfc.Families[0], 38);*/

            //MessageBox.Show(path);
            this.applyOnStartUp();

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

            btnDiscord.BackColor = Color.FromArgb(topBar1, topBar2, topBar3);
            btnReleases.BackColor = Color.FromArgb(topBar1, topBar2, topBar3);
            btnReddit.BackColor = Color.FromArgb(topBar1, topBar2, topBar3);
            btnGitHub.BackColor = Color.FromArgb(topBar1, topBar2, topBar3);
            btnHelp.BackColor = Color.FromArgb(topBar1, topBar2, topBar3);
            btnPatreon.BackColor = Color.FromArgb(topBar1, topBar2, topBar3);


            path2 = path2 + "//bin//Notification.exe";
            path3 = path3 + "//bin//oc.exe";

            pathAC = pathAC + "//bin//atrofac-cli.exe";
            if (args == "" || args == null && ac == false)
            {

            }
            else
            {
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                startInfo.CreateNoWindow = true;
                startInfo.FileName = pathAC;
                startInfo.Arguments = args;
                process.StartInfo = startInfo;
                process.Start();

                startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                startInfo.CreateNoWindow = true;
                startInfo.FileName = path3;
                startInfo.Arguments = "0 " + (int)Settings.Default["coreClock"] + " " + (int)Settings.Default["memClock"];
                process.StartInfo = startInfo;
                process.Start();

                startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                startInfo.CreateNoWindow = true;
                startInfo.FileName = path3;
                startInfo.Arguments = "1 " + (int)Settings.Default["coreClock"] + " " + (int)Settings.Default["memClock"];
                process.StartInfo = startInfo;
                process.Start();

                startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                startInfo.CreateNoWindow = true;
                startInfo.FileName = path3;
                startInfo.Arguments = "2 " + (int)Settings.Default["coreClock"] + " " + (int)Settings.Default["memClock"];
                process.StartInfo = startInfo;
                process.Start();
            }

        }

        private void Theme_Tick(object sender, EventArgs e)
        {
            bool useDefaultTheme = (bool)Settings.Default["useDefaultTheme"];
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

            btnDiscord.BackColor = Color.FromArgb(topBar1, topBar2, topBar3);
            btnReleases.BackColor = Color.FromArgb(topBar1, topBar2, topBar3);
            btnReddit.BackColor = Color.FromArgb(topBar1, topBar2, topBar3);
            btnGitHub.BackColor = Color.FromArgb(topBar1, topBar2, topBar3);
            btnHelp.BackColor = Color.FromArgb(topBar1, topBar2, topBar3);
            btnPatreon.BackColor = Color.FromArgb(topBar1, topBar2, topBar3);
        }

        private void btnDiscord_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.gg/ampBxnyKaz");
        }

        private void btnGitHub_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/FlyGoat/RyzenAdj");
        }

        private void btnReddit_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.reddit.com/r/RyzenShine/");
        }


        private void applyOnStartUp()
        {
            path = (string)Settings.Default["Path"];
            path = path + "\\bin\\ryzenadj.exe";

            RyzenADJ = (string)Settings.Default["RyzenADJ"];

            if (startUp == true)
            {
                if (RyzenADJ == "" || RyzenADJ == null || path == "" || path == null)
                {
                    return;
                }
                else
                {
                    Process proc = new Process();
                    proc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    proc.StartInfo.CreateNoWindow = true;
                    proc.StartInfo.RedirectStandardOutput = true;
                    proc.StartInfo.FileName = path;
                    proc.StartInfo.Arguments = RyzenADJ;
                    proc.StartInfo.UseShellExecute = false;
                    proc.Start();
                }
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/FlyGoat/RyzenAdj/wiki/Supported-Models");
        }

        private void applyOnStart_Tick(object sender, EventArgs e)
        {
            if (startUp == true)
            {
                if (i <= 3)
                {
                    applyOnStartUp();
                }

                if (i < 1)
                {
                    if (RyzenADJ == "" || RyzenADJ == null || path == "" || path == null)
                    {

                    }
                    else
                    {
                        Process proc = new Process();
                        proc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                        proc.StartInfo.FileName = path2;
                        proc.StartInfo.Arguments = "https://media.discordapp.net/attachments/711708420281204768/813512272935780412/AATU-LOGO.png?width=697&height=676 Applied-Successfully! Your-settings-have-been-applied-successfully";
                        proc.Start();
                    }
                }
            }

            i++;

            if (i >= 3)
            {
                applyOnStart.Enabled = false;
            }
        }

        private void btnPatreon_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.patreon.com/aatusoftware");
        }

        private void btnReleases_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/JamesCJ60/AMD-APU-Tuning-Utility/releases");
        }
    }
}
