using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Management;


namespace B00tme
{
    public partial class MainForm : Form
    {
        //Credits:
        //OpenSuSe Imagewriter's code helped me a lot with writing raw image data to connected disks, especially the interop and WMI stuff!
        //Unetbootin inspired me to use an online repo for getting the image files.

        List<ManagementObject> Disks = new List<ManagementObject>();
        public MainForm()
        {
            InitializeComponent();
            ManagementObjectCollection disks = GetDisks(false);
            

            consoleOutput(string.Format("Amount of disks: {0}\r\n\r\n", disks.Count));
            string diskinfo = "";
            int iteration = 0;
            foreach (var item in disks)
            {
                iteration++;
                diskinfo += item.ClassPath.ToString() + "\r\n\r\n\r\n";
                foreach (var property in item.Properties)
                {
                    if (property.Value != null)
                    {
                        diskinfo += property.Name + " " + property.Type;

                        diskinfo += ":" + property.Value.ToString();

                        diskinfo += "\r\n";

                        
                    }
                }
            }

            diskinfo += "\r\nIterations: " + iteration;
            consoleOutput(diskinfo);
            System.IO.File.WriteAllText("disks.txt", diskinfo);
        }

        void consoleOutput(string ToOutput)
        {
            richTextBox_ConsoleOutput.Text += ToOutput;
        }
        void consoleOutputLine(string ToOutput)
        {
            richTextBox_ConsoleOutput.Text += ToOutput + "\r\n";
        }
        
         ManagementObjectCollection GetDisks(bool USBonly)
        {
            //string model;
            //string deviceString;
            string query = "SELECT * FROM Win32_DiskDrive ";
            if(USBonly)query += "WHERE InterfaceType = \"USB\"";
            ManagementObjectSearcher physicalSearch = new ManagementObjectSearcher(query);
            return physicalSearch.Get();
            //foreach (ManagementObject physicalDrive in physicalSearch.Get())
            //{
            //    if (physicalDrive["MediaType"].ToString().Substring(0, 9) != "Removable")
            //        continue;

            //    if (physicalDrive["Model"] == null)
            //        model = "Unknown Device";
            //    else
            //        model = physicalDrive["Model"].ToString();
            //    deviceString = model + " - (" + Math.Round(((double)Convert.ToDouble(physicalDrive["Size"]) / 1048576), 2) + " MB)";
            //    //ImageDevice newDevice = new ImageDevice(deviceString);
            //    newDevice.size = (long)Convert.ToInt64(physicalDrive["Size"]);
            //    newDevice.name = physicalDrive["Name"].ToString();
            //    newDevice.partitions = Convert.ToInt32(physicalDrive["Partitions"]);
            //    // Now see if there are any mounted volumes
            //    foreach (ManagementObject partition in new ManagementObjectSearcher("ASSOCIATORS OF {Win32_DiskDrive.DeviceID='" + physicalDrive["DeviceID"] + "'} WHERE AssocClass = Win32_DiskDriveToDiskPartition").Get())
            //        foreach (ManagementObject disk in new ManagementObjectSearcher("ASSOCIATORS OF {Win32_DiskPartition.DeviceID='" + partition["DeviceID"] + "'} WHERE AssocClass = Win32_LogicalDiskToPartition").Get())
            //            newDevice.volume = "\\\\.\\" + disk["Name"].ToString();
            //    deviceCombo.Items.Add(newDevice);
            //}
            
        }

    }
}
