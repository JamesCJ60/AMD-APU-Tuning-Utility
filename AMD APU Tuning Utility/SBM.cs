using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AMD_APU_Tuning_Utility.Properties;
using System.Diagnostics;
using System.IO;

namespace AMD_APU_Tuning_Utility
{
    public partial class SBM : UserControl
    {
        public static SBM _instance;
        public static SBM Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new SBM();
                return _instance;
            }
        }
        public SBM()
        {
            InitializeComponent();
        }

        string APUName = (string)Settings.Default["APUName"];

        int battery;
        int batteryOld;
        int CPUTDP;
        int maxCPUTDP;
        int minCPUTDP;
        int LongBoostDuration = 50;
        int shortBoostDuration = 3000;
        int VRM;
        int boostMode = 1;
        int MaxCPUPerf = 100;
        int ES = 45;


        int topBar1 = 0;
        int topBar2 = 180;
        int topBar3 = 166;

        int sideBar1 = 0;
        int sideBar2 = 110;
        int sideBar3 = 106;

        string RyzenADJ = "";
        string path = "";
        string path2 = "";

        bool SBMEnabled = false;

        bool useDefaultTheme = (bool)Settings.Default["useDefaultTheme"];

        PowerStatus p;

        private void batteryTimer_Tick(object sender, EventArgs e)
        {
            getBattery();

            if(SBMEnabled == true)
            {
                ES = 75;

                if (battery == batteryOld - 5)
                {
                    if (CPUTDP > minCPUTDP)
                    {
                        if (APUName.Contains("HX") || APUName.Contains("HS") || APUName.Contains("H"))
                        {
                            CPUTDP = CPUTDP - 1000;
                            VRM = VRM - 1000;
                        }
                        else
                        {
                            CPUTDP = CPUTDP - 500;
                            VRM = VRM - 500;
                        }
                    }
                    batteryOld = battery;
                }
                else if (battery == batteryOld + 5)
                {
                    if (CPUTDP < maxCPUTDP)
                    {
                        if (APUName.Contains("HX") || APUName.Contains("HS") || APUName.Contains("H"))
                        {
                            CPUTDP = CPUTDP + 1000;
                            VRM = VRM + 1000;
                        }
                        else
                        {
                            CPUTDP = CPUTDP + 500;
                            VRM = VRM + 500;
                        }
                    }
                    batteryOld = battery;
                }

                if (battery > 75)
                {
                    boostMode = 1;
                    MaxCPUPerf = 100;
                    lblPerformance.Text = "Performance Status: Your APU is currently running at peak possible performance";
                }
                if (battery <= 75 && battery > 25)
                {
                    boostMode = 0;
                    MaxCPUPerf = 100;
                    lblPerformance.Text = "Performance Status: Your APU is no longer running at peak possible performance";
                }
                if (battery <= 25)
                {
                    boostMode = 0;
                    MaxCPUPerf = 50;
                }

                applyRyzenADJ();
            }
            
        }

        private void SBM_Load(object sender, EventArgs e)
        {

            if (useDefaultTheme == false)
            {
                topBar1 = (int)Settings.Default["topBar1"];
                topBar2 = (int)Settings.Default["topBar2"];
                topBar3 = (int)Settings.Default["topBar3"];

                sideBar1 = (int)Settings.Default["sideBar1"];
                sideBar2 = (int)Settings.Default["sideBar2"];
                sideBar3 = (int)Settings.Default["sideBar3"];

            }
            else if (useDefaultTheme == true)
            {
                topBar1 = 0;
                topBar2 = 180;
                topBar3 = 166;

                sideBar1 = 0;
                sideBar2 = 110;
                sideBar3 = 106;

            }
            btnEnabled.BackColor = Color.FromArgb(topBar1, topBar2, topBar3);

            getBattery();
            
            if (APUName.Contains("HX"))
            {
                maxCPUTDP = 35000;
                minCPUTDP = 12000;
                VRM = 50000;
            }
            else if (APUName.Contains("HS"))
            {
                maxCPUTDP = 25000;
                minCPUTDP = 7000;
                VRM = 40000;
            }
            else if (APUName.Contains("H"))
            {
                maxCPUTDP = 30000;
                minCPUTDP = 12000;
                VRM = 45000;
            }
            else if (APUName.Contains("U") || APUName.Contains("Athlon"))
            {
                maxCPUTDP = 16000;
                minCPUTDP = 6000;
                VRM = 36000;
            }

            CPUTDP = maxCPUTDP;

            if (battery >= 90 && battery <=95)
            {
                if (APUName.Contains("HX") || APUName.Contains("HS") || APUName.Contains("H"))
                {
                    CPUTDP = maxCPUTDP - 2000;
                    VRM = VRM - 2000;
                }
                else
                {
                    CPUTDP = maxCPUTDP - 1000;
                    VRM = VRM - 1000;
                }

                batteryOld = 90;
            }
            else if (battery >= 80)
            {
                if (APUName.Contains("HX") || APUName.Contains("HS") || APUName.Contains("H"))
                {
                    CPUTDP = maxCPUTDP - 4000;
                    VRM = VRM - 4000;
                }
                else
                {
                    CPUTDP = maxCPUTDP - 2000;
                    VRM = VRM - 2000;
                }
                batteryOld = 80;
            }
            else if (battery >= 70)
            {
                if (APUName.Contains("HX") || APUName.Contains("HS") || APUName.Contains("H"))
                {
                    CPUTDP = maxCPUTDP - 6000;
                    VRM = VRM - 6000;
                }
                else
                {
                    CPUTDP = maxCPUTDP - 3000;
                    VRM = VRM - 3000;
                }
                batteryOld = 70;
            }
            else if (battery >= 60)
            {
                if (APUName.Contains("HX") || APUName.Contains("HS") || APUName.Contains("H"))
                {
                    CPUTDP = maxCPUTDP - 8000;
                    VRM = VRM - 8000;
                }
                else
                {
                    CPUTDP = maxCPUTDP - 4000;
                    VRM = VRM - 4000;
                }
                batteryOld = 60;
            }
            else if (battery >= 50)
            {
                if (APUName.Contains("HX") || APUName.Contains("HS") || APUName.Contains("H"))
                {
                    CPUTDP = maxCPUTDP - 10000;
                    VRM = VRM - 10000;
                }
                else
                {
                    CPUTDP = maxCPUTDP - 5000;
                    VRM = VRM - 5000;
                }
                batteryOld = 50;
            }
            else if (battery >= 40)
            {
                if (APUName.Contains("HX") || APUName.Contains("HS") || APUName.Contains("H"))
                {
                    CPUTDP = maxCPUTDP - 12000;
                    VRM = VRM - 12000;
                }
                else
                {
                    CPUTDP = maxCPUTDP - 6000;
                    VRM = VRM - 6000;
                }

                batteryOld = 40;
            }
            else if (battery >= 30)
            {
                if (APUName.Contains("HX") || APUName.Contains("HS") || APUName.Contains("H"))
                {
                    CPUTDP = maxCPUTDP - 14000;
                    VRM = VRM - 14000;
                }
                else
                {
                    CPUTDP = maxCPUTDP - 7000;
                    VRM = VRM - 7000;
                }
                batteryOld = 30;
            }
            else if (battery >= 20)
            {
                if (APUName.Contains("HX") || APUName.Contains("HS") || APUName.Contains("H"))
                {
                    CPUTDP = maxCPUTDP - 16000;
                    VRM = VRM - 16000;
                }
                else
                {
                    CPUTDP = maxCPUTDP - 8000;
                    VRM = VRM - 8000;
                }
                batteryOld = 30;
            }
            else if (battery >= 10)
            {
                if (APUName.Contains("HX") || APUName.Contains("HS") || APUName.Contains("H"))
                {
                    CPUTDP = maxCPUTDP - 18000;
                    VRM = VRM - 18000;
                }
                else
                {
                    CPUTDP = maxCPUTDP - 9000;
                    VRM = VRM - 9000;
                }
                batteryOld = 10;
            }

            applyRyzenADJ();
        }

        private async void getBattery()
        {
            await Task.Run(() =>
            {
                p = SystemInformation.PowerStatus;
                battery = (int)(p.BatteryLifePercent * 100);
            });

            lblBattery.Text = "Battery Life: " + battery + "%";
        }

        private async void applyRyzenADJ()
        {
            RyzenADJ = "--tctl-temp=" + 85 + " --stapm-limit=" + CPUTDP + " --fast-limit=" + CPUTDP + " --stapm-time=" + LongBoostDuration + " --slow-limit=" + minCPUTDP + " --slow-time=" + shortBoostDuration + " --vrmmax-current=" + VRM + " --vrm-current=" + (VRM - 1500) + " --power-saving";

            path = (string)Settings.Default["Path"];
            path2 = (string)Settings.Default["Path"];
            path = path + "\\bin\\ryzenadj.exe ";

            path2 = path2 + "\\bin\\Notification.exe";

            await Task.Run(() =>
            {
                if (RyzenADJ == "" || RyzenADJ == null)
                {
                    return;
                }
                else
                    try
                    {
                        {
                            System.Diagnostics.Process process = new System.Diagnostics.Process();
                            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                            startInfo.CreateNoWindow = true;
                            startInfo.RedirectStandardOutput = true;
                            startInfo.UseShellExecute = false;

                            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                            startInfo.FileName = "powercfg";
                            startInfo.Arguments = "-setdcvalueindex scheme_current sub_processor PERFBOOSTMODE " + boostMode;
                            process.StartInfo = startInfo;
                            process.Start();

                            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                            startInfo.FileName = "powercfg";
                            startInfo.Arguments = "-setdcvalueindex SCHEME_CURRENT SUB_ENERGYSAVER ESBATTTHRESHOLD " + ES;
                            process.StartInfo = startInfo;
                            process.Start();

                            if (!APUName.Contains("Athlon"))
                            {
                                startInfo.FileName = "powercfg";
                                startInfo.Arguments = "-setdcvalueindex scheme_current sub_processor CPMAXCORES " + MaxCPUPerf;
                                process.StartInfo = startInfo;
                                process.Start();
                                startInfo.FileName = "powercfg";
                            }

                            startInfo.FileName = "powercfg";
                            startInfo.Arguments = "/setactive scheme_current";
                            process.StartInfo = startInfo;
                            process.Start();


                            Process proc = new Process();
                            proc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                            proc.StartInfo.CreateNoWindow = true;
                            proc.StartInfo.RedirectStandardOutput = true;
                            proc.StartInfo.FileName = "CMD";
                            proc.StartInfo.Arguments = path + RyzenADJ + "; exit";
                            proc.StartInfo.UseShellExecute = false;
                            proc.Start();

                        }
                    }

                    catch (Exception)
                    {
                        System.Diagnostics.Process process = new System.Diagnostics.Process();
                        System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                        startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                        startInfo.FileName = path2;
                        startInfo.Arguments = "https://media.discordapp.net/attachments/711708420281204768/813512272935780412/AATU-LOGO.png?width=697&height=676 Error! Something-went-wrong-when-applying-your-settings-:(";
                        process.StartInfo = startInfo;
                        process.Start();
                    }
            });
        }

        private void btnEnabled_Click(object sender, EventArgs e)
        {
            if (btnEnabled.Text == "Start Adaptive ECO Mode")
            {
                SBMEnabled = true;
                btnEnabled.Text = "Stop Adaptive ECO Mode && Revert Power Plan Settings";
            } else
            {
                SBMEnabled = false;
                btnEnabled.Text = "Start Adaptive ECO Mode";

                boostMode = 1;
                MaxCPUPerf = 100;
                ES = 45;

                CPUTDP = maxCPUTDP;

                Settings.Default["CPUTurbo"] = false;
                Settings.Default.Save();

                applyRyzenADJ();
            }
        }

        private void Theme_Tick(object sender, EventArgs e)
        {
            useDefaultTheme = (bool)Settings.Default["useDefaultTheme"];

            if (useDefaultTheme == false)
            {
                topBar1 = (int)Settings.Default["topBar1"];
                topBar2 = (int)Settings.Default["topBar2"];
                topBar3 = (int)Settings.Default["topBar3"];

                sideBar1 = (int)Settings.Default["sideBar1"];
                sideBar2 = (int)Settings.Default["sideBar2"];
                sideBar3 = (int)Settings.Default["sideBar3"];

            }
            else if (useDefaultTheme == true)
            {
                topBar1 = 0;
                topBar2 = 180;
                topBar3 = 166;

                sideBar1 = 0;
                sideBar2 = 110;
                sideBar3 = 106;

            }
            btnEnabled.BackColor = Color.FromArgb(topBar1, topBar2, topBar3);
        }
    }
}
