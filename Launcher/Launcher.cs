﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace Launcher
{
    public partial class Launcher : Form
    {
        public Launcher()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                using (Process myProcess = new Process())
                {
                    myProcess.StartInfo.UseShellExecute = false;
                    myProcess.StartInfo.FileName = Application.StartupPath + "/WindowsNoEditor/Demo/Binaries/Win64/Demo.exe";
                    myProcess.StartInfo.CreateNoWindow = true;
                    myProcess.Start();
                }
            }
            catch (Exception ex)
            {
                //TODO warning or error Window
                MessageBox.Show(ex.ToString() + "\n No puede ejecutar Demo.exe");
                //throw;
            }
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.Show();
        }

        private void btnReadMe_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(Application.StartupPath + "/Readme.txt");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString() + "\n No puede ejecutar ReadMe");
                //throw;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}