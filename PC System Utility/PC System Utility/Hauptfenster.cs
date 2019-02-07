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
using Microsoft.VisualBasic.Devices;

namespace PC_System_Utility
{
    public partial class FormHauptfenster : Form
    {
        public FormHauptfenster()
        {
            InitializeComponent();
        }

        private void FormHauptfenster_Load(object sender, EventArgs e)
        {
            RegistryKey Registrierung = Registry.LocalMachine;
            RegistryKey Ordner = Registrierung.OpenSubKey("HARDWARE\\DESCRIPTION\\System\\CentralProcessor\\0");
            Object CpuNameTaktrate = Ordner.GetValue("ProcessorNameString");

            int CpuKerne = System.Environment.ProcessorCount;

            ComputerInfo PcInfo = new ComputerInfo();
            ulong RAM = PcInfo.TotalPhysicalMemory;
            
            ListboxCpuInfo.Items.Add(CpuNameTaktrate);

            if (CpuKerne >= 8)
            {
                ListboxCpuInfo.Items.Add(CpuKerne / 2 + " physische Prozessorkerne" + " / " + CpuKerne + " logische Prozessorkerne");

                if (CpuNameTaktrate.ToString().Split(' ')[0].Contains("Intel"))
                    ListboxCpuInfo.Items.Add("Hyperthreading");
                else
                    ListboxCpuInfo.Items.Add("Simultaneous Multithreading");
            }
            else
            {
                ListboxCpuInfo.Items.Add(CpuKerne + " physische Prozessorkerne");

                if (CpuNameTaktrate.ToString().Split(' ')[0].Contains("Intel"))
                    ListboxCpuInfo.Items.Add("Kein Hyperthreading");
                else
                    ListboxCpuInfo.Items.Add("Kein Simultaneous Multithreading");
            }

            ListboxRamInfo.Items.Add(RAM / (1024 * 1024) + " MB RAM");
        }

        private void ButtonCpuTesten_Click(object sender, EventArgs e)
        {

        }

        private void ButtonTaskManagerStarten_Click(object sender, EventArgs e)
        {
            Process.Start("taskmgr.exe");
        }
    }
}
