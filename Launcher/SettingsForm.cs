using Launcher.Properties;
using IniParser;
using IniParser.Model;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Launcher
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            boxResolution.SelectedIndex =        Properties.Settings.Default.ResolutionID;
            EnableMotionBlur.Checked =          Properties.Settings.Default.MotionBlurSetting;
            EnableAmbientOcclusion.Checked =    Properties.Settings.Default.AOSetting;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                //string configFilePath = Application.ExecutablePath + "/WindowsNoEditor/Demo/Saved/Config/WindowsNoEditor/GameUserSettings.ini";
                string configFilePath = "WindowsNoEditor/Demo/Saved/Config/WindowsNoEditor/GameUserSettings.ini";
                var parser = new FileIniDataParser();
                IniData data = parser.ReadFile(configFilePath);

                data["ScalabilityGroups"]["sg.ResolutionQuality"] = "100.0";
                parser.WriteFile(configFilePath, data);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString() + "\n No se encuentra archivo de configuración");
                //throw;
            }




            Properties.Settings.Default.ResolutionSetting = boxResolution.SelectedText;
            Properties.Settings.Default.ResolutionID = boxResolution.SelectedIndex;
            Properties.Settings.Default.MotionBlurSetting = EnableMotionBlur.Checked;
            Properties.Settings.Default.AOSetting = EnableAmbientOcclusion.Checked;
            Properties.Settings.Default.Save();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
