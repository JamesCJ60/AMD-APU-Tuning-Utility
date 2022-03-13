using AMD_APU_Tuning_Utility.Properties;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AMD_APU_Tuning_Utility
{
    public partial class SettingsMenu : UserControl
    {
        public static SettingsMenu _instance;
        public static SettingsMenu Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new SettingsMenu();
                return _instance;
            }
        }

        bool useDefaultTheme = (bool)Settings.Default["useDefaultTheme"];
        bool useGPUSettings = (bool)Settings.Default["useGPUSettings"];
        bool discord = (bool)Settings.Default["Discord"];
        bool tray = (bool)Settings.Default["Tray"];
        bool boot = (bool)Settings.Default["Boot"];
        bool auto = (bool)Settings.Default["AutoApply"];
        bool applyonstart = (bool)Settings.Default["Startup"];
        bool CPUTurbo = (bool)Settings.Default["CPUTurbo"];
        bool SkinTemp = (bool)Settings.Default["SkinTemp"];
        bool AC = (bool)Settings.Default["AC"];
        bool Premade = (bool)Settings.Default["hidePremade"];

        int topBar1 = 0;
        int topBar2 = 180;
        int topBar3 = 166;

        int sideBar1 = 0;
        int sideBar2 = 110;
        int sideBar3 = 106;

        public SettingsMenu()
        {
            InitializeComponent();
        }

        private void SettingsMenu_Load(object sender, EventArgs e)
        {
            cbDiscord.Checked = discord;
            cbTray.Checked = tray;
            cbCPUTurbo.Checked = CPUTurbo;
            cbSkinTemp.Checked = SkinTemp;
            cbROG.Checked = AC;
            cbHidePremade.Checked = Premade;

            if (useDefaultTheme == false)
            {
                topBar1 = (int)Settings.Default["topBar1"];
                topBar2 = (int)Settings.Default["topBar2"];
                topBar3 = (int)Settings.Default["topBar3"];

                sideBar1 = (int)Settings.Default["sideBar1"];
                sideBar2 = (int)Settings.Default["sideBar2"];
                sideBar3 = (int)Settings.Default["sideBar3"];
                
                cbCustomTheme.Checked = true;
            }
            else if (useDefaultTheme == true)
            {
                topBar1 = 0;
                topBar2 = 180;
                topBar3 = 166;

                sideBar1 = 0;
                sideBar2 = 110;
                sideBar3 = 106;
                cbCustomTheme.Checked = false;
            }

            if(useGPUSettings == true)
            {
                cbGPUSettings.Checked = true;
            } else
            {
                cbGPUSettings.Checked = false;
            }

            if(boot == true)
            {
                cbBoot.Checked = true;
            }
            else
            {
                cbBoot.Checked = false;
            }

            if (auto == true)
            {
                cbAuto.Checked = true;
            }
            else
            {
                cbAuto.Checked = false;
            }

            if(applyonstart == true)
            {
                cbApplyStart.Checked = true;
            } else
            {
                cbApplyStart.Checked = false;
            }

            btnSave.BackColor = Color.FromArgb(topBar1, topBar2, topBar3);


            

            nudTopRed.Value = (int)Settings.Default["topBar1"];
            nudTopBlue.Value = (int)Settings.Default["topBar2"];
            nudTopGreen.Value = (int)Settings.Default["topBar3"];

            nudSideRed.Value = (int)Settings.Default["sideBar1"];
            nudSideBlue.Value = (int)Settings.Default["sideBar2"];
            nudSideGreen.Value = (int)Settings.Default["sideBar3"];
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Settings.Default["topBar1"] = Convert.ToInt32(nudTopRed.Value);
            Settings.Default["topBar2"] = Convert.ToInt32(nudTopBlue.Value);
            Settings.Default["topBar3"] = Convert.ToInt32(nudTopGreen.Value);

            Settings.Default["sideBar1"] = Convert.ToInt32(nudSideRed.Value);
            Settings.Default["sideBar2"] = Convert.ToInt32(nudSideBlue.Value);
            Settings.Default["sideBar3"] = Convert.ToInt32(nudSideGreen.Value);
            Settings.Default["Discord"] = cbDiscord.Checked;
            Settings.Default["Tray"] = cbTray.Checked;
            Settings.Default["AutoApply"] = cbAuto.Checked;
            


            if (cbCustomTheme.Checked == false)
            {
                useDefaultTheme = true;
            }
            else
            {
                useDefaultTheme = false;
                
            }

            if (cbGPUSettings.Checked == true)
            {
                useGPUSettings = true;
            }
            else
            {
                useGPUSettings = false;

            }

            if(cbApplyStart.Checked == true)
            {
                applyonstart = true;
            } else
            {
                applyonstart = false;
            }

            if(cbBoot.Checked == true)
            {
                if(boot == false)
                {
                    var path = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Run";
                    RegistryKey key = Registry.CurrentUser.OpenSubKey(path, true);
                    key.SetValue("MyApplication", Application.ExecutablePath.ToString());

                    boot = true;
                }
            } else if (cbBoot.Checked == false)
            {
                if(boot == true)
                {
                    var path = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Run";
                    RegistryKey key = Registry.CurrentUser.OpenSubKey(path, true);
                    key.DeleteValue("MyApplication", false);

                    boot = false;
                }
            }

            if (cbAuto.Checked == true)
            {
                auto = true;
            }
            else 
            {
                auto = false;
            }

            Settings.Default["AutoApply"] = auto;
            Settings.Default["Boot"] = boot;
            Settings.Default["useDefaultTheme"] = useDefaultTheme;
            Settings.Default["useGPUSettings"] = useGPUSettings;
            Settings.Default["Startup"] = applyonstart;
            Settings.Default.Save();
        }

        private void Theme_Tick(object sender, EventArgs e)
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
            btnSave.BackColor = Color.FromArgb(topBar1, topBar2, topBar3);
        }

        private async void cbCPUTurbo_CheckedChanged(object sender, EventArgs e)
        {
            int MaxCPUPerf = 100;
            int boostMode = 1;

            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;

            if (cbCPUTurbo.Checked == true)
            {
                //CPUPerf
                MaxCPUPerf = 99;
                boostMode = 0;

                CPUTurbo = true;
            }
            else
            {
                MaxCPUPerf = 100;
                boostMode = 1;

                CPUTurbo = false;
            }

            await Task.Run(() =>
            {
                startInfo.FileName = "powercfg";
                startInfo.Arguments = "-setacvalueindex scheme_current sub_processor PERFBOOSTMODE " + boostMode;
                process.StartInfo = startInfo;
                process.Start();
                System.Threading.Thread.Sleep(300);

                startInfo.FileName = "powercfg";
                startInfo.Arguments = "/setactive scheme_current";
                process.StartInfo = startInfo;
                process.Start();

                startInfo.FileName = "powercfg";
                startInfo.Arguments = "-setacvalueindex scheme_current sub_processor PROCTHROTTLEMAX " + MaxCPUPerf;
                process.StartInfo = startInfo;
                process.Start();
                System.Threading.Thread.Sleep(300);

                startInfo.FileName = "powercfg";
                startInfo.Arguments = "/setactive scheme_current";
                process.StartInfo = startInfo;
                process.Start();

                startInfo.FileName = "powercfg";
                startInfo.Arguments = "-setdcvalueindex scheme_current sub_processor PERFBOOSTMODE " + boostMode;
                process.StartInfo = startInfo;
                process.Start();
                System.Threading.Thread.Sleep(300);

                startInfo.FileName = "powercfg";
                startInfo.Arguments = "/setactive scheme_current";
                process.StartInfo = startInfo;
                process.Start();

                startInfo.FileName = "powercfg";
                startInfo.Arguments = "-setdcvalueindex scheme_current sub_processor PROCTHROTTLEMAX " + MaxCPUPerf;
                process.StartInfo = startInfo;
                process.Start();
                System.Threading.Thread.Sleep(300);

                startInfo.FileName = "powercfg";
                startInfo.Arguments = "/setactive scheme_current";
                process.StartInfo = startInfo;
                process.Start();

                Settings.Default["CPUTurbo"] = CPUTurbo;
                Settings.Default.Save();
            });
        }

        private void cbSkinTemp_CheckedChanged(object sender, EventArgs e)
        {
            if(cbSkinTemp.Checked == true)
            {
                SkinTemp = true;
            }
            else
            {
                SkinTemp = false;
            }

            Settings.Default["SkinTemp"] = SkinTemp;
            Settings.Default.Save();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (cbROG.Checked == true)
            {
                AC = true;
            }
            else
            {
                AC = false;
            }

            Settings.Default["AC"] = AC;
            Settings.Default.Save();
        }

        private void cbHidePremade_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Default["hidePremade"] = (bool)cbHidePremade.Checked;
            Settings.Default.Save();
        }
    }
}
