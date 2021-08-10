using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AMD_APU_Tuning_Utility
{
    public partial class SysInfo : UserControl
    {
        public static SysInfo _instance;
        public static SysInfo Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new SysInfo();
                return _instance;
            }
        }

        public SysInfo()
        {
            InitializeComponent();
        }

        public void CPUDetails()
        {
            ManagementObjectSearcher myProcessorObject = new ManagementObjectSearcher("select * from Win32_Processor");

            foreach (ManagementObject obj in myProcessorObject.Get())
            {
                lblCPUInfo.Items.Add("Name  -  " + obj["Name"]);
                lblCPUInfo.Items.Add("Manufacturer  -  " + obj["Manufacturer"]);
                lblCPUInfo.Items.Add("Caption  -  " + obj["Caption"]);
                lblCPUInfo.Items.Add("NumberOfCores  -  " + obj["NumberOfCores"]);
                lblCPUInfo.Items.Add("NumberOfEnabledCore  -  " + obj["NumberOfEnabledCore"]);
                lblCPUInfo.Items.Add("NumberOfLogicalProcessors  -  " + obj["NumberOfLogicalProcessors"]);             
            }
        }

        public void GPUDetails()
        {
            ManagementObjectSearcher myVideoObject = new ManagementObjectSearcher("select * from Win32_VideoController");
            int i = 1;

            foreach (ManagementObject obj in myVideoObject.Get())
            {
                if(i > 1)
                {
                    lblGPUInfo.Items.Add("");
                }
                lblGPUInfo.Items.Add("GPU No.  -  " + i);
                lblGPUInfo.Items.Add("Name  -  " + obj["Name"]);
                lblGPUInfo.Items.Add("Status  -  " + obj["Status"]);
                lblGPUInfo.Items.Add("Caption  -  " + obj["Caption"]);
                lblGPUInfo.Items.Add("DriverVersion  -  " + obj["DriverVersion"]);
                lblGPUInfo.Items.Add("VideoProcessor  -  " + obj["VideoProcessor"]);
                i++;
            }
        }

        public void StorageDetails()
        {
            DriveInfo[] allDrives = DriveInfo.GetDrives();

            foreach (DriveInfo d in allDrives)
            {
                lblStorageInfo.Items.Add("Drive " +  d.Name);
                if (d.IsReady == true)
                {
                    lblStorageInfo.Items.Add("      Volume label: " + d.VolumeLabel);
                    lblStorageInfo.Items.Add("      File system: " + d.DriveFormat);
                    lblStorageInfo.Items.Add("      Available space to current user: " + d.AvailableFreeSpace / 1024 / 1024 / 1024  + " GB");

                    lblStorageInfo.Items.Add("      Total available space:           " + d.TotalFreeSpace / 1024 / 1024 / 1024 + " GB");

                    lblStorageInfo.Items.Add("      Total size of drive:             " +  d.TotalSize / 1024 /1024 /1024 + " GB");
                    lblStorageInfo.Items.Add("");
                }
            }
        }

        private void SysInfo_Load(object sender, EventArgs e)
        {
            CPUDetails();
            GPUDetails();
            StorageDetails();
        }

        private void DetailsUpdater_Tick(object sender, EventArgs e)
        {
            
            lblGPUInfo.Items.Clear();
            lblStorageInfo.Items.Clear();

            
            GPUDetails();
            StorageDetails();
        }
    }
}
