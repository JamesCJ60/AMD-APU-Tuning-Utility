using AMD_APU_Tuning_Utility.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AMD_APU_Tuning_Utility
{
    public partial class GPUOC : UserControl
    {
        public GPUOC()
        {
            InitializeComponent();
        }

        public static GPUOC _instance;
        public static GPUOC Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new GPUOC();
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

        int iGPUClock = 0;

        string RyzenADJ;
        string path;
        string path2;
        string path3;

        bool connection = true;

        private void GPUOC_Load(object sender, EventArgs e)
        {
            //rbStatic.Checked = true;

            bool useGPUSettings = (bool)Settings.Default["useGPUSettings"];
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
        }

        private void tbStatic_Scroll(object sender, EventArgs e)
        {
            nudStatic.Value = tbStatic.Value;
        }

        private void nudStatic_ValueChanged(object sender, EventArgs e)
        {
            tbStatic.Value = (int)nudStatic.Value;
        }

        private void tbCore_Scroll(object sender, EventArgs e)
        {
            nudCore.Value = (int)tbCore.Value;
        }

        private void nudCore_ValueChanged(object sender, EventArgs e)
        {
            tbCore.Value = (int)nudCore.Value;
        }

        private void tbMem_Scroll(object sender, EventArgs e)
        {
            nudMem.Value = (int)tbMem.Value;
        }

        private void nudMem_ValueChanged(object sender, EventArgs e)
        {
            tbMem.Value = (int)nudMem.Value;
        }

        private void rbStatic_CheckedChanged(object sender, EventArgs e)
        {
            if (rbStatic.Checked == true)
            {
                nudStatic.Enabled = true;
                tbStatic.Enabled = true;
            }
        }


        private void Theme_Tick(object sender, EventArgs e)
        {
            bool useGPUSettings = (bool)Settings.Default["useGPUSettings"];
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

            if (rbStatic.Checked == true)
            {
                iGPUClock = (int)nudStatic.Value;
                RyzenADJ = RyzenADJ + "--gfx-clk=" + iGPUClock + " ";
            }

            if (cbcoGFXMag.Text.Contains("+"))
            {
                RyzenADJ = RyzenADJ + "--set-cogfx=" + (int)nudcoGFX.Value + " ";
            }
            if (cbcoGFXMag.Text.Contains("-"))
            {

                RyzenADJ = RyzenADJ + "--set-cogfx=" + Convert.ToUInt32(0x100000 - (int)nudcoGFX.Value) + " ";
                
            }

            if (cbiGPUOC.Checked == true)
            {
                if (RyzenADJ == "" || RyzenADJ == null)
                {


                    if (connection == true)
                    {
                        System.Diagnostics.Process process = new System.Diagnostics.Process();
                        System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                        startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                        startInfo.FileName = path2;
                        startInfo.Arguments = "https://media.discordapp.net/attachments/711708420281204768/813512272935780412/AATU-LOGO.png?width=697&height=676 Error! There-are-no-settings-to-apply!-Please-enter-some-settings";
                        process.StartInfo = startInfo;
                        process.Start();
                    }
                    else
                    {
                        MessageBox.Show("There are no settings to apply! Please enter some settings", "Error!");
                    }
                }
                else
                {
                    try
                    {
                        System.Diagnostics.Process process = new System.Diagnostics.Process();
                        System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                        startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                        startInfo.CreateNoWindow = true;
                        startInfo.FileName = path;
                        startInfo.Arguments = RyzenADJ;
                        process.StartInfo = startInfo;
                        process.Start();

                        if (connection == true)
                        {
                            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                            startInfo.CreateNoWindow = false;
                            startInfo.FileName = path2;
                            startInfo.Arguments = "https://media.discordapp.net/attachments/711708420281204768/813512272935780412/AATU-LOGO.png?width=697&height=676 Applied-Successfully! Your-settings-have-been-applied-successfully";
                            process.StartInfo = startInfo;
                            process.Start();
                        }
                        else
                        {
                            MessageBox.Show("Your settings have been applied successfully", "Applied Successfully!");
                        }
                    }
                    catch
                    {
                        if (connection == true)
                        {
                            System.Diagnostics.Process process = new System.Diagnostics.Process();
                            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                            startInfo.FileName = path2;
                            startInfo.Arguments = "https://media.discordapp.net/attachments/711708420281204768/813512272935780412/AATU-LOGO.png?width=697&height=676 Error! Something-went-wrong-when-applying-your-settings-:(";
                            process.StartInfo = startInfo;
                            process.Start();
                        }
                        else
                        {
                            MessageBox.Show("Something went wrong when applying your settings :(", "Error!");
                        }
                    }
                }
            } 
            if(cbNVidia.Checked == true)
            {
                try
                {
                    System.Diagnostics.Process process = new System.Diagnostics.Process();
                    System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                    startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                    startInfo.FileName = path3;
                    startInfo.Arguments = "0 " + nudCore.Value + " " + nudMem.Value;
                    process.StartInfo = startInfo;
                    process.Start();

                    startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                    startInfo.FileName = path3;
                    startInfo.Arguments = "1 " + nudCore.Value + " " + nudMem.Value;
                    process.StartInfo = startInfo;
                    process.Start();

                    startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                    startInfo.FileName = path3;
                    startInfo.Arguments = "2 " + nudCore.Value + " " + nudMem.Value;
                    process.StartInfo = startInfo;
                    process.Start();

                    if (connection == true)
                    {
                        startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                        startInfo.CreateNoWindow = false;
                        startInfo.FileName = path2;
                        startInfo.Arguments = "https://media.discordapp.net/attachments/711708420281204768/813512272935780412/AATU-LOGO.png?width=697&height=676 Applied-Successfully! Your-settings-have-been-applied-successfully";
                        process.StartInfo = startInfo;
                        process.Start();
                    }
                    else
                    {
                        MessageBox.Show("Your settings have been applied successfully", "Applied Successfully!");
                    }
                }
                catch
                {
                    if (connection == true)
                    {
                        System.Diagnostics.Process process = new System.Diagnostics.Process();
                        System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                        startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                        startInfo.FileName = path2;
                        startInfo.Arguments = "https://media.discordapp.net/attachments/711708420281204768/813512272935780412/AATU-LOGO.png?width=697&height=676 Error! Something-went-wrong-when-applying-your-settings-:(";
                        process.StartInfo = startInfo;
                        process.Start();
                    }
                    else
                    {
                        MessageBox.Show("Something went wrong when applying your settings :(", "Error!");
                    }
                }
            }

            if(cbiGPUOC.Checked == false && cbNVidia.Checked == false)
            {
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                startInfo.FileName = path2;
                startInfo.Arguments = "https://media.discordapp.net/attachments/711708420281204768/813512272935780412/AATU-LOGO.png?width=697&height=676 Error! There-are-no-settings-to-apply!-Please-enter-some-settings";
                process.StartInfo = startInfo;
                process.Start();
            }

        }
    }
}
