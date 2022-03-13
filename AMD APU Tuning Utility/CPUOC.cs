using AMD_APU_Tuning_Utility.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AMD_APU_Tuning_Utility
{
    public partial class CPUOC : UserControl
    {
        public CPUOC()
        {
            InitializeComponent();
        }

        public static CPUOC _instance;
        public static CPUOC Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new CPUOC();
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

        string RyzenADJ;
        string path;
        string path2;
        string path3;


        private void nudStatic_ValueChanged(object sender, EventArgs e)
        {
            tbStatic.Value = (int)nudStatic.Value;
        }

        private void tbStatic_Scroll(object sender, EventArgs e)
        {
            nudStatic.Value = (int)tbStatic.Value;
        }

        private void CPUOC_Load(object sender, EventArgs e)
        {
            nudcoCPU.Value = (int)Settings.Default["coALL"];
            nudStatic.Value = (int)Settings.Default["cpuOC"];
            nudVID.Value = (int)Settings.Default["cpuVID"];

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


            btnApply.BackColor = Color.FromArgb(topBar1, topBar2, topBar3);
            btnDisable.BackColor = Color.FromArgb(topBar1, topBar2, topBar3);
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
            btnApply.BackColor = Color.FromArgb(topBar1, topBar2, topBar3);
            btnDisable.BackColor = Color.FromArgb(topBar1, topBar2, topBar3);
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            path = (string)Settings.Default["Path"];
            path2 = (string)Settings.Default["Path"];
            path3 = (string)Settings.Default["Path"];
            path = path + "\\bin\\ryzenadj.exe";
            path2 = path2 + "\\bin\\Notification.exe";
            path3 = path3 + "\\bin\\oc.exe";
            RyzenADJ = null;

            if (cbOverClockCPU.Checked == true || cbVID.Checked == true)
            {
                RyzenADJ = RyzenADJ + "--enable-oc" + " ";
            }

            if (cbOverClockCPU.Checked == true)
            {
                RyzenADJ = RyzenADJ + "--oc-clk=" + nudStatic.Value + " ";
            }

            if (cbVID.Checked == true)
            {
                double vid = Math.Round((double)nudVID.Value / 1000, 2);
                RyzenADJ = RyzenADJ + "--oc-volt=" + Convert.ToUInt32((1.55 - vid) / 0.00625) + " ";
            }

            if (cbCPUCO.Checked == true)
            {
                if (cbcoCPUMag.Text.Contains("+"))
                {
                    RyzenADJ = RyzenADJ + "--set-coall=" + Convert.ToUInt32((int)nudcoCPU.Value) + " ";
                }
                if (cbcoCPUMag.Text.Contains("-"))
                {
                    RyzenADJ = RyzenADJ + "--set-coall=" + Convert.ToUInt32(0x100000 - (int)nudcoCPU.Value) + " ";
                }
            }

            if(RyzenADJ != null || RyzenADJ != "")
            {
                int i = 0;
                do
                {
                    System.Diagnostics.Process process = new System.Diagnostics.Process();
                    System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                    startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                    startInfo.CreateNoWindow = true;
                    startInfo.FileName = path;
                    startInfo.Arguments = RyzenADJ;
                    process.StartInfo = startInfo;
                    process.Start();
                    i++;
                } 
                while (i <= 3);
            }

            Settings.Default["coALL"] = (int)nudcoCPU.Value;
            Settings.Default["cpuOC"] = (int)nudStatic.Value;
            Settings.Default["cpuVID"] = (int)nudVID.Value;
            Settings.Default.Save();
        }

        private void btnDisable_Click(object sender, EventArgs e)
        {
            path = (string)Settings.Default["Path"];
            path2 = (string)Settings.Default["Path"];
            path3 = (string)Settings.Default["Path"];
            path = path + "\\bin\\ryzenadj.exe";
            path2 = path2 + "\\bin\\Notification.exe";
            path3 = path3 + "\\bin\\oc.exe";
            RyzenADJ = null;

            RyzenADJ = "--disable-oc";
            if (RyzenADJ != null || RyzenADJ != "")
            {
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                startInfo.CreateNoWindow = true;
                startInfo.FileName = path;
                startInfo.Arguments = RyzenADJ;
                process.StartInfo = startInfo;
                process.Start();
            }
        }
    }
}
