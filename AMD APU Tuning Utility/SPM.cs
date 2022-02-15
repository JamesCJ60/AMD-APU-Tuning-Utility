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
using OpenHardwareMonitor.Hardware;

namespace AMD_APU_Tuning_Utility
{
    public partial class SPM : UserControl
    {
        public static SPM _instance;
        public static SPM Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new SPM();
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

        public static Computer thisPC;

        public SPM()
        {
            InitializeComponent();

            thisPC = new Computer()
            {
                CPUEnabled = true,
                GPUEnabled = true,
            };
            thisPC.Open();
        }

        private void Theme_Tick(object sender, EventArgs e)
        {
            getHWInfo();

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

        private void SPM_Load(object sender, EventArgs e)
        {
            nudCPU.Value = (int)Settings.Default["apCPU"];
            nudGPU.Value = (int)Settings.Default["apGPU"];
            nudMaxTDP.Value = (int)Settings.Default["apTDP"];
            nudTemp.Value = (int)Settings.Default["apTemp"];

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

        bool startAPM = false;

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (btnApply.Text == "Start AP Mode")
            {
                btnApply.Text = "Stop AP Mode";
                startAPM = true;
            }
            else
            {
                btnApply.Text = "Start AP Mode";
                startAPM = false;
            }
        }

        public int iGPClock = 1500;
        public int coreClock = 4000;
        public int maxClock = 450;
        public int minClock = 400;
        public int lastResult = 0;
        public int lastClock = 0;
        public int maxWatt = 45;
        public int cpuUsage = 0;
        public int gpuUsage = 0;
        public int oldWatt = 0;
        public int oldClock = 0;
        public int clear = 2;
        public int temp = 60;
        public int currentWatt = 10;
        public int iGPTemp = 0;
        public int cpuTemp = 0;
        public int currentClock = 0;
        public int currentCoreClock = 0;
        public int currentMemClock = 900;
        public int result = 100;
        public int test = 0;

        public bool wasEnabled = false;
        public void tboGFX(int offset, int clock)
        {
            iGPClock = clock;
            maxClock = offset;
            //int currentWatt = (int)Math.Round(get_socket_power(ry))

            try
            {
                Process[] pname = Process.GetProcessesByName("3DMark");

                int newClock = iGPClock;

                if (currentClock!> 0)
                {
                    currentClock = lastClock;
                }


                if (maxWatt < 27)
                {
                    clear = 3;
                }
                else if (maxWatt <= 18)
                {
                    clear = 6;
                }
                else if (maxWatt < 38)
                {
                    clear = 2;
                }
                else
                {
                    clear = 0;
                }

                if (result >= 85 && result <= 91 && iGPTemp <= temp)
                {
                    return;
                }
                else if (result > 91 && iGPTemp <= temp && currentWatt <= maxWatt - clear)
                {
                    if (currentClock != iGPClock + maxClock)
                    {
                        if (currentClock < iGPClock)
                        {
                            newClock = currentClock + 150;
                        }
                        else
                        {
                            newClock = currentClock + 50;
                        }

                    }
                }
                else if (iGPTemp > temp || result < 90 || currentWatt >= maxWatt)
                {
                    if (currentClock > minClock && result > 50)
                    {
                        newClock = currentClock - 50;
                    }
                    else if (currentClock > minClock && result < 50)
                    {
                        newClock = currentClock - 75;
                    }
                }
                if (currentWatt >= maxWatt || currentMemClock < 600)
                {
                    if (currentClock > minClock)
                    {
                        newClock = currentClock - 75;
                    }
                }

                if (result <= 8 && pname.Length < 1)
                {
                    newClock = minClock;
                    lastResult = 10;
                }

                if (result <= 2 && pname.Length < 1)
                {
                    newClock = minClock - 200;
                    lastResult = 5;
                }

                if (currentClock > iGPClock + maxClock)
                {
                    newClock = (iGPClock + maxClock) - 10;
                }

                if (lastResult <= 40 && result > 45 && currentWatt <= maxWatt - clear || lastResult <= 40 && result > 45 && currentWatt <= maxWatt - clear && pname.Length >= 1)
                {
                    if (pname.Length >= 1)
                    {
                        newClock = iGPClock + (offset / 2);
                        lastResult = (int)result;
                    }
                    else
                    {
                        newClock = (iGPClock - 200);
                        lastResult = (int)result;
                    }

                }

                if (currentClock < (iGPClock - 300) && result > 80 && iGPTemp < temp && lastResult < 40 || currentClock < (iGPClock - 300) && result > 80 && iGPTemp < temp && pname.Length >= 1)
                {
                    if (pname.Length >= 1)
                    {
                        newClock = (int)Math.Round(iGPClock + (offset / 1.5));
                        lastResult = (int)result;
                    }
                    else
                    {
                        newClock = (iGPClock - 125);
                        lastResult = (int)result;
                    }
                }

                if (newClock <= (lastClock - 15) || newClock >= (lastClock + 15))
                {
                    //set_gfx_clk(ry, (uint)newClock);
                    //currentClock = (int)get_gfx_clk(ry);

                    string path = (string)Settings.Default["Path"];
                    path = path + "\\bin\\ryzenadj.exe";
                    string RyzenADJ = "--gfx-clk=" + newClock;

                    lblTest1.Text = RyzenADJ;

                    System.Diagnostics.Process process = new System.Diagnostics.Process();
                    System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                    startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                    startInfo.CreateNoWindow = true;
                    startInfo.FileName = path;
                    startInfo.Arguments = RyzenADJ;
                    process.StartInfo = startInfo;
                    process.Start();

                    lastClock = newClock;
                }
                lastResult = (int)result;
            }
            catch
            {

            }
        }

        public void getHWInfo()
        {
            foreach (var hardware in thisPC.Hardware)
            {
                hardware.Update();
                if (hardware.HardwareType == HardwareType.CPU)
                {
                    foreach (var sensor in hardware.Sensors)
                        if (sensor.SensorType == SensorType.Temperature && sensor.Name.Contains("Package"))
                        {
                            iGPTemp = (int)sensor.Value.GetValueOrDefault(); // CPU Package Temp
                            cpuTemp = (int)sensor.Value.GetValueOrDefault(); // CPU Package Temp
                            lblTest3.Text = cpuTemp.ToString();

                        }

                    foreach (var sensor in hardware.Sensors)
                        if (sensor.SensorType == SensorType.Clock && sensor.Name.Contains("Core"))
                        {
                            currentClock = (int)sensor.Value.GetValueOrDefault(); // CPU Clock

                        }

                    foreach (var sensor in hardware.Sensors)
                        if (sensor.SensorType == SensorType.Load)
                        {
                            cpuUsage = (int)sensor.Value.GetValueOrDefault(); // CPU Usage

                        }

                    foreach (var sensor in hardware.Sensors)
                        if (sensor.SensorType == SensorType.Power & sensor.Name.Contains("CPU Package"))
                        {

                            currentWatt = (int)sensor.Value.GetValueOrDefault(); // CPU Package Power
                            currentWatt = currentWatt + 6;
                            lblTest4.Text = currentWatt.ToString();

                        }
                }

                if (hardware.HardwareType == HardwareType.GpuAti)
                {
                    foreach (var sensor in hardware.Sensors)
                    {
                        if (sensor.SensorType == SensorType.Clock && sensor.Name.Contains("Core"))
                        {
                            if (!hardware.Name.Contains("56") || !hardware.Name.Contains("64"))
                            {
                                if (hardware.Name.Contains("Vega") && hardware.Name.Contains("3") || hardware.Name.Contains("Vega") && hardware.Name.Contains("6") || hardware.Name.Contains("Vega") && hardware.Name.Contains("8") || hardware.Name.Contains("Vega") && hardware.Name.Contains("9") || hardware.Name.Contains("Vega") && hardware.Name.Contains("10") || hardware.Name.Contains("Vega") && hardware.Name.Contains("11") || hardware.Name == "AMD Radeon Graphics" || hardware.Name == "AMD Radeon(TM) Graphics" || hardware.Name == "AMD Radeon RX Vega Graphics")
                                {
                                    currentClock = (int)sensor.Value.GetValueOrDefault();
                                    lblTest5.Text = currentClock.ToString();
                                }
                            }
                        }

                        if (sensor.SensorType == SensorType.Clock && sensor.Name.Contains("Mem"))
                        {
                            if (!hardware.Name.Contains("56") || !hardware.Name.Contains("64"))
                            {
                                if (hardware.Name.Contains("Vega") && hardware.Name.Contains("3") || hardware.Name.Contains("Vega") && hardware.Name.Contains("6") || hardware.Name.Contains("Vega") && hardware.Name.Contains("8") || hardware.Name.Contains("Vega") && hardware.Name.Contains("9") || hardware.Name.Contains("Vega") && hardware.Name.Contains("10") || hardware.Name.Contains("Vega") && hardware.Name.Contains("11") || hardware.Name == "AMD Radeon Graphics" || hardware.Name == "AMD Radeon(TM) Graphics" || hardware.Name == "AMD Radeon RX Vega Graphics")
                                {
                                    currentMemClock = (int)sensor.Value.GetValueOrDefault();
                                }
                            }
                        }

                        if (sensor.SensorType == SensorType.Load && sensor.Name.Contains("Core"))
                        {
                            if (!hardware.Name.Contains("56") || !hardware.Name.Contains("64"))
                            {
                                if (hardware.Name.Contains("Vega") && hardware.Name.Contains("3") || hardware.Name.Contains("Vega") && hardware.Name.Contains("6") || hardware.Name.Contains("Vega") && hardware.Name.Contains("8") || hardware.Name.Contains("Vega") && hardware.Name.Contains("9") || hardware.Name.Contains("Vega") && hardware.Name.Contains("10") || hardware.Name.Contains("Vega") && hardware.Name.Contains("11") || hardware.Name == "AMD Radeon Graphics" || hardware.Name == "AMD Radeon(TM) Graphics" || hardware.Name == "AMD Radeon RX Vega Graphics")
                                {
                                    result = (int)sensor.Value.GetValueOrDefault();
                                    lblTest6.Text = result.ToString();
                                }
                            }
                        }
                    }
                }
            }



            //MessageBox.Show(Convert.ToString(currentWatt) + "W " + Convert.ToString(temp) + "c");
        }

        public void adaptivePerf(bool enabled, int TDP)
        {
            int minWatt = 10;
            try
            {
                string apuname = (string)Settings.Default["APUName"];

                if (enabled == true)
                {
                    maxWatt = TDP;
                }
                else if (apuname.Contains("U"))
                {
                    maxWatt = 48;
                    minWatt = 10;
                }
                else if (apuname.Contains("HX"))
                {
                    maxWatt = 100;
                    minWatt = 20;
                }
                else if (apuname.Contains("HS"))
                {
                    maxWatt = 70;
                    minWatt = 15;
                }
                else if (apuname.Contains("H"))
                {
                    maxWatt = 85;
                    minWatt = 20;
                }
                else if (apuname.Contains("GE"))
                {
                    maxWatt = 88;
                    minWatt = 35;
                }
                else if (apuname.Contains("G"))
                {
                    maxWatt = 128;
                    minWatt = 65;
                }

                int newWatt = maxWatt;

                if (cpuTemp <= temp - 10)
                {
                    if (currentWatt != maxWatt)
                    {
                        if (currentWatt < maxWatt)
                        {
                            newWatt = currentWatt + 5;
                        }
                    }
                }

                if (cpuTemp >= temp)
                {
                    if (currentWatt > minWatt)
                    {
                        newWatt = currentWatt - 2;
                    }
                }

                if (newWatt > maxWatt)
                {
                    newWatt = maxWatt;
                }

                else if (newWatt < minWatt)
                {
                    newWatt = minWatt;
                }

                if (cpuUsage > 5 && cpuTemp < temp - 10 || currentMemClock < 600 && cpuTemp < temp - 10 || currentWatt < maxWatt && cpuTemp < temp - 10)
                {
                    if (newWatt < maxWatt)
                    {
                        newWatt = maxWatt;
                    }
                }

                if (newWatt >= oldWatt + 1 || newWatt <= oldWatt - 1)
                {
                    /*
                    set_apu_skin_temp_limit(ry, (uint)temp);
                    set_tctl_temp(ry, (uint)temp);
                    set_stapm_limit(ry, (uint)newWatt * 1000);
                    set_fast_limit(ry, (uint)newWatt * 1000);
                    set_slow_limit(ry, (uint)newWatt * 1000);
                    set_vrm_current(ry, (uint)(newWatt * 2) * 1000);
                    set_vrmmax_current(ry, (uint)(newWatt * 2.5) * 1000);
                    set_slow_time(ry, 64);
                    set_stapm_time(ry, 1024);
                    */
                    oldWatt = newWatt;

                    int watt = newWatt *1000;

                    string path = (string)Settings.Default["Path"];
                    path = path + "\\bin\\ryzenadj.exe";
                    string RyzenADJ = "--tctl-temp=" + temp + " " + "--apu-skin-temp=" + temp + " " + "--stapm-limit=" + watt + " " + "--fast-limit=" + watt + " " + "--slow-limit=" + watt + " " + "--vrm-current=" + (newWatt * 2) * 1000 + " " + "--vrmmax-current=" + (newWatt * 2) * 1000 + " " + "--slow-time=" + 64 + " " + "--stapm-time=" + 1024;

                    if (cbTBOGPU.Enabled == true)
                    {
                        lblTest2.Text = "Output: " + RyzenADJ + " " + "--gfx-clk=" + currentClock;
                    }
                    else
                    {
                        lblTest2.Text = "Output: " + RyzenADJ;
                    }


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
            catch
            {

            }
        }


        private void APMode_Tick(object sender, EventArgs e)
        {
            temp = (int)nudTemp.Value;

            getHWInfo();

            string apuname = (string)Settings.Default["APUName"];

            if (apuname.Contains("4300U"))
            {
                iGPClock = 1400;
            }
            else if (apuname.Contains("4500U") || apuname.Contains("4600U") || apuname.Contains("5300U"))
            {
                iGPClock = 1500;
            }
            else if (apuname.Contains("4700U"))
            {
                iGPClock = 1600;
            }
            else if(apuname.Contains("4800U"))
            {
                iGPClock = 1750;
            }
            else if(apuname.Contains("5500U"))
            {
                iGPClock = 1800;
            }
            else if(apuname.Contains("5700U") || apuname.Contains("4600G") || apuname.Contains("4650G"))
            {
                iGPClock = 1900;
            }
            else if(apuname.Contains("4300G") || apuname.Contains("4350G"))
            {
                iGPClock = 1700;
            }
            else if(apuname.Contains("4700G") || apuname.Contains("4750G"))
            {
                iGPClock = 2100;
            }
            else
            {
                cbTBOGPU.Enabled = false;
            }

            if (apuname.Contains("G") || apuname.Contains("HX"))
            {
                cbTBOCPU.Enabled = true;
            }
            else
            {
                cbTBOCPU.Enabled = false;
            }

            if (startAPM == true)
            {
                if (cbTBOGPU.Checked == true)
                {
                    tboGFX((int)nudGPU.Value, iGPClock);
                }

                if (cbTBOGPU.Checked == true)
                {
                    adaptivePerf((bool)cbMaxTDP.Checked, (int)nudMaxTDP.Value);
                }

                if (cbTBOCPU.Checked == true)
                {
                    if (apuname.Contains("4150G") || apuname.Contains("4100G"))
                    {
                        tboCPU(3800, (int)nudCPU.Value);
                        wasEnabled = true;
                    }
                    if (apuname.Contains("4300G") || apuname.Contains("4350G"))
                    {
                        tboCPU(3900, (int)nudCPU.Value);
                        wasEnabled = true;
                    }
                    if (apuname.Contains("4600G") || apuname.Contains("4650G"))
                    {
                        tboCPU(3800, (int)nudCPU.Value);
                        wasEnabled = true;
                    }
                    if (apuname.Contains("4700G") || apuname.Contains("4750G"))
                    {
                        tboCPU(4000, (int)nudCPU.Value);
                        wasEnabled = true;
                    }
                    if (apuname.Contains("5300G") || apuname.Contains("5350G"))
                    {
                        tboCPU(4000, (int)nudCPU.Value);
                        wasEnabled = true;
                    }
                    if (apuname.Contains("5600G") || apuname.Contains("5650G"))
                    {
                        tboCPU(4200, (int)nudCPU.Value);
                        wasEnabled = true;
                    }
                    if (apuname.Contains("5700G") || apuname.Contains("5750G") || apuname.Contains("5980HX"))
                    {
                        tboCPU(4400, (int)nudCPU.Value);
                        wasEnabled = true;
                    }
                    if (apuname.Contains("5900HX"))
                    {
                        tboCPU(4200, (int)nudCPU.Value);
                        wasEnabled = true;
                    }
                    if (apuname.Contains("6900HX"))
                    {
                        tboCPU(4300, (int)nudCPU.Value);
                        wasEnabled = true;
                    }
                    if (apuname.Contains("6980HX"))
                    {
                        tboCPU(4500, (int)nudCPU.Value);
                        wasEnabled = true;
                    }
                }

                Settings.Default["apCPU"] = (int)nudCPU.Value;
                Settings.Default["apGPU"] = (int)nudGPU.Value;
                Settings.Default["apTDP"] =  (int)nudMaxTDP.Value;
                Settings.Default["apTemp"] = (int)nudTemp.Value;
                Settings.Default.Save();
            }

            if (wasEnabled == true && cbTBOCPU.Checked == false || wasEnabled == true && startAPM == false)
            {
                string path = (string)Settings.Default["Path"];
                path = path + "\\bin\\ryzenadj.exe";
                string RADJ = "--disable-oc";

                System.Diagnostics.Process process = new System.Diagnostics.Process();
                System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                startInfo.CreateNoWindow = true;
                startInfo.FileName = path;
                startInfo.Arguments = RADJ;
                process.StartInfo = startInfo;
                process.Start();

                wasEnabled = false;
            }
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        public void tboCPU(int stockClock, int offset)
        {
            int newClock = currentClock;
            int maxCPUClock = (stockClock + offset) + 50;
            try
            {

                if (cpuTemp <= temp - 10)
                {
                    if (currentWatt != maxWatt)
                    {
                        if (currentWatt < maxWatt && currentClock < maxClock)
                        {
                            newClock = currentClock + 25;
                        }
                    }
                }

                if (cpuTemp >= temp)
                {
                    newClock = currentClock - 25;
                }

                if (newClock > maxCPUClock)
                {
                    newClock = maxCPUClock;
                }

                if (cpuUsage > 40 && cpuTemp < temp - 10 || currentMemClock < 600 && cpuTemp < temp - 10 || currentWatt < maxWatt && cpuTemp < temp - 10)
                {
                    if (newClock < maxCPUClock)
                    {
                        newClock = maxCPUClock - 25;
                    }
                }

                if (cpuUsage > 65 && cpuTemp < temp - 10 || currentMemClock < 600 && cpuTemp < temp - 10 || currentWatt < maxWatt && cpuTemp < temp - 10)
                {
                    if (newClock < maxCPUClock)
                    {
                        newClock = maxCPUClock - 50;
                    }
                }

                if (cpuUsage > 85 && cpuTemp < temp - 10 || currentMemClock < 600 && cpuTemp < temp - 10 || currentWatt < maxWatt && cpuTemp < temp - 10)
                {
                    if (newClock < maxCPUClock)
                    {
                        newClock = maxCPUClock - 75;
                    }
                }

                if (cpuTemp >= temp - 2 || currentMemClock < 600 && cpuTemp < temp - 2 || currentWatt < maxWatt && cpuTemp < temp - 2)
                {
                    newClock = newClock - 25;
                }

                if (newClock > maxCPUClock)
                {
                    newClock = maxCPUClock;
                }

                /*
                set_apu_skin_temp_limit(ry, (uint)temp);
                set_tctl_temp(ry, (uint)temp);
                set_stapm_limit(ry, (uint)newWatt * 1000);
                set_fast_limit(ry, (uint)newWatt * 1000);
                set_slow_limit(ry, (uint)newWatt * 1000);
                set_vrm_current(ry, (uint)(newWatt * 2) * 1000);
                set_vrmmax_current(ry, (uint)(newWatt * 2.5) * 1000);
                set_slow_time(ry, 64);
                set_stapm_time(ry, 1024);
                */
                

                string path = (string)Settings.Default["Path"];
                path = path + "\\bin\\ryzenadj.exe";

                int core = Environment.ProcessorCount;
                string RADJ = "";

                core = (int)((100/core) * 1.3);


                if (cpuUsage > core && newClock > stockClock - 175)
                {
                    RADJ = "--oc-clk=" + newClock + " " +  "--enable-oc";
                }
                else
                {
                    RADJ = "--disable-oc";
                }
                test++;
                lblTest7.Text = RADJ + " " + core + " " + 100 / core + " " + test + " " + cpuUsage;

                if(newClock > oldClock + 1 || newClock < oldClock -1 || RADJ.Contains("--disable") || currentClock != newClock)
                {
                    System.Diagnostics.Process process = new System.Diagnostics.Process();
                    System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                    startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                    startInfo.CreateNoWindow = true;
                    startInfo.FileName = path;
                    startInfo.Arguments = RADJ;
                    process.StartInfo = startInfo;
                    process.Start();
                }

                oldClock = newClock;

            }
            catch
            {

            }
        }

        private void cbTBOCPU_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTBOCPU.Checked == true)
            {
                cbPerf.Checked = true;
            }
        }

        private void cbTBOGPU_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTBOGPU.Checked == true)
            {
                cbPerf.Checked = true;
            }
        }

        private void cbPerf_CheckedChanged(object sender, EventArgs e)
        {
            if(cbPerf.Checked == false)
            {
                cbTBOGPU.Checked = false;
                cbTBOCPU.Checked = false;
            }
        }
    }
}
