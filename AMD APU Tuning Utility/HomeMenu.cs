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


        string RyzenADJ = (string)Settings.Default["RyzenADJ"];
        bool startUp = (bool)Settings.Default["Startup"];
        string path = (string)Settings.Default["Path"];
        

        public HomeMenu()
        {
            InitializeComponent();
        }

        private void HomeMenu_Load(object sender, EventArgs e)
        {
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


            string args = (string)Settings.Default["Args"];
            string pathAC = (string)Settings.Default["Path"];
            bool ac = (bool)Settings.Default["AC"];

            pathAC = pathAC + "//bin//atrofac-cli.exe";
            if (args == "" || args == null && ac == false)
            {

            }
            else
            {
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                startInfo.FileName = pathAC;
                startInfo.Arguments = args;
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
        }

        private void btnDiscord_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.gg/ampBxnyKaz");
        }

        private void btnReleases_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://gitlab.com/JamesCJ/amd-apu-tuning-utility/-/releases");
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
            if (startUp == true)
            {
                if (RyzenADJ == "" || RyzenADJ == null || path == "" || path == null)
                {
                    return;
                }
                else
                {
                    Process process = new Process();
                    ProcessStartInfo startInfo = new ProcessStartInfo();
                    startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    startInfo.FileName = path;
                    startInfo.Arguments = RyzenADJ;
                    process.StartInfo = startInfo;
                    process.Start();
                    Settings.Default["RyzenADJ"] = RyzenADJ;
                    MessageBox.Show("Your settings have been applied!", "Settings Applied", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/FlyGoat/RyzenAdj/wiki/Supported-Models");
        }
    }
}
