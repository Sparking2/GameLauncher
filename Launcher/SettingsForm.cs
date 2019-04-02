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
        private bool bChangingForPreset = false;

        public SettingsForm()
        {
            InitializeComponent();
            radioQPLow.CheckedChanged += new EventHandler(radioButtons_CheckedChanged);
            radioQPMedium.CheckedChanged += new EventHandler(radioButtons_CheckedChanged);
            radioQPHigh.CheckedChanged += new EventHandler(radioButtons_CheckedChanged);
            radioQPUltra.CheckedChanged += new EventHandler(radioButtons_CheckedChanged);
            radioQPCustom.CheckedChanged += new EventHandler(radioButtons_CheckedChanged);

            comboViewDistance.SelectedIndexChanged += new EventHandler(comboBox_SelectedIndexChanged);
            comboAA.SelectedIndexChanged += new EventHandler(comboBox_SelectedIndexChanged);
            comboPostProcessing.SelectedIndexChanged += new EventHandler(comboBox_SelectedIndexChanged);
            comboShadow.SelectedIndexChanged += new EventHandler(comboBox_SelectedIndexChanged);
            comboTexture.SelectedIndexChanged += new EventHandler(comboBox_SelectedIndexChanged);
            comboEffects.SelectedIndexChanged += new EventHandler(comboBox_SelectedIndexChanged);
            comboFoliage.SelectedIndexChanged += new EventHandler(comboBox_SelectedIndexChanged);
        }

        private void radioButtons_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            if (radioButton.Checked == true)
            {
                bChangingForPreset = true;
                switch (radioButton.Name.ToString())
                {
                    case "radioQPLow":
                        comboViewDistance.SelectedIndex = 0;
                        comboAA.SelectedIndex = 0;
                        comboPostProcessing.SelectedIndex = 0;
                        comboShadow.SelectedIndex = 0;
                        comboTexture.SelectedIndex = 0;
                        comboEffects.SelectedIndex = 0;
                        comboFoliage.SelectedIndex = 0;
                        break;
                    case "radioQPMedium":
                        comboViewDistance.SelectedIndex = 1;
                        comboAA.SelectedIndex = 1;
                        comboPostProcessing.SelectedIndex = 1;
                        comboShadow.SelectedIndex = 1;
                        comboTexture.SelectedIndex = 1;
                        comboEffects.SelectedIndex = 1;
                        comboFoliage.SelectedIndex = 1;
                        break;
                    case "radioQPHigh":
                        comboViewDistance.SelectedIndex = 2;
                        comboAA.SelectedIndex = 2;
                        comboPostProcessing.SelectedIndex = 2;
                        comboShadow.SelectedIndex = 2;
                        comboTexture.SelectedIndex = 2;
                        comboEffects.SelectedIndex = 2;
                        comboFoliage.SelectedIndex = 2;
                        break;
                    case "radioQPUltra":
                        comboViewDistance.SelectedIndex = 3;
                        comboAA.SelectedIndex = 3;
                        comboPostProcessing.SelectedIndex = 3;
                        comboShadow.SelectedIndex = 3;
                        comboTexture.SelectedIndex = 3;
                        comboEffects.SelectedIndex = 3;
                        comboFoliage.SelectedIndex = 3;
                        break;
                    case "radioQPCustom":
                        //comboViewDistance.SelectedIndex     = Properties.Settings.Default.ViewDistanceID;
                        //comboAA.SelectedIndex               = Properties.Settings.Default.AAID;
                        //comboPostProcessing.SelectedIndex   = Properties.Settings.Default.PostID;
                        //comboShadow.SelectedIndex           = Properties.Settings.Default.ShadowID;
                        //comboTexture.SelectedIndex          = Properties.Settings.Default.TextureID;
                        //comboEffects.SelectedIndex          = Properties.Settings.Default.EffectsID;
                        //comboFoliage.SelectedIndex          = Properties.Settings.Default.FoliageID;
                        break;
                }
                bChangingForPreset = false;
            }
        }
        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bChangingForPreset == false)
                radioQPCustom.Select();
        }


        private void SettingsForm_Load(object sender, EventArgs e)
        {
            ///Screen Options
            boxResolution.SelectedIndex = Properties.Settings.Default.ResolutionID;
            boxVSync.Checked = Properties.Settings.Default.EnabledVSync;
            boxDynamicResolution.Checked = Properties.Settings.Default.EnableDynamicResolution;
            comboFPS.SelectedIndex = Properties.Settings.Default.FPSLimit;
            comboScreenMode.SelectedIndex = Properties.Settings.Default.ScreenModeID;
            ///Quality Presets
            switch (Properties.Settings.Default.QualityPresetID)
            {
                case 0: radioQPLow.Select(); break;
                case 1: radioQPMedium.Select(); break;
                case 2: radioQPHigh.Select(); break;
                case 3: radioQPUltra.Select(); break;
                case 4: radioQPCustom.Select(); break;

            }
            ///Quality Options
            comboViewDistance.SelectedIndex = Properties.Settings.Default.ViewDistanceID;
            comboAA.SelectedIndex = Properties.Settings.Default.AAID;
            comboPostProcessing.SelectedIndex = Properties.Settings.Default.PostID;
            comboShadow.SelectedIndex = Properties.Settings.Default.ShadowID;
            comboTexture.SelectedIndex = Properties.Settings.Default.TextureID;
            comboEffects.SelectedIndex = Properties.Settings.Default.EffectsID;
            comboFoliage.SelectedIndex = Properties.Settings.Default.FoliageID;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string configFilePath = "Demo/Saved/Config/WindowsNoEditor/GameUserSettings.ini";
                var parser = new FileIniDataParser();
                IniData data = parser.ReadFile(configFilePath);
                ///Screen Resolution
                switch (boxResolution.SelectedIndex)
                {
                    case 0:
                        data["/Script/Engine.GameUserSettings"]["ResolutionSizeX"] = "800";
                        data["/Script/Engine.GameUserSettings"]["ResolutionSizeY"] = "600";
                        data["/Script/Engine.GameUserSettings"]["DesiredScreenWidth"] = "800";
                        data["/Script/Engine.GameUserSettings"]["DesiredScreenHeight"] = "600";
                        break;
                    case 1:
                        data["/Script/Engine.GameUserSettings"]["ResolutionSizeX"] = "1024";
                        data["/Script/Engine.GameUserSettings"]["ResolutionSizeY"] = "768";
                        data["/Script/Engine.GameUserSettings"]["DesiredScreenWidth"] = "1024";
                        data["/Script/Engine.GameUserSettings"]["DesiredScreenHeight"] = "768";
                        break;
                    case 2:
                        data["/Script/Engine.GameUserSettings"]["ResolutionSizeX"] = "1280";
                        data["/Script/Engine.GameUserSettings"]["ResolutionSizeY"] = "720";
                        data["/Script/Engine.GameUserSettings"]["DesiredScreenWidth"] = "1280";
                        data["/Script/Engine.GameUserSettings"]["DesiredScreenHeight"] = "720";
                        break;
                    case 3:
                        data["/Script/Engine.GameUserSettings"]["ResolutionSizeX"] = "1920";
                        data["/Script/Engine.GameUserSettings"]["ResolutionSizeY"] = "1080";
                        data["/Script/Engine.GameUserSettings"]["DesiredScreenWidth"] = "1920";
                        data["/Script/Engine.GameUserSettings"]["DesiredScreenHeight"] = "1080";
                        break;
                }
                ///Enable Vertical Sync
                data["/Script/Engine.GameUserSettings"]["bUseVSync"] = boxVSync.Checked == true ? "True" : "False";
                ///Enable Dynamic Resolution
                data["/Script/Engine.GameUserSettings"]["bUseDynamicResolution"] = boxDynamicResolution.Checked == true ? "True" : "False";
                ///FPS Limit
                switch (comboFPS.SelectedIndex)
                {
                    case 0:
                        data["/Script/Engine.GameUserSettings"]["FrameRateLimit"] = "30.0";
                        break;
                    case 1:
                        data["/Script/Engine.GameUserSettings"]["FrameRateLimit"] = "60.0";
                        break;
                    case 2:
                        data["/Script/Engine.GameUserSettings"]["FrameRateLimit"] = "120.0";
                        break;
                    case 3:
                        data["/Script/Engine.GameUserSettings"]["FrameRateLimit"] = "144.0";
                        break;
                    case 4:
                        data["/Script/Engine.GameUserSettings"]["FrameRateLimit"] = "240.0";
                        break;
                    default:
                        data["/Script/Engine.GameUserSettings"]["FrameRateLimit"] = "0.000000";
                        break;
                }
                ///Window Mode 0 Full 1 WindowFull 2 Window
                data["/Script/Engine.GameUserSettings"]["FullscreenMode"] = comboScreenMode.SelectedIndex.ToString();
                ///ViewDistance
                data["ScalabilityGroups"]["sg.ViewDistanceQuality"] = comboViewDistance.SelectedIndex.ToString();
                ///AA
                data["ScalabilityGroups"]["sg.AntiAliasingQuality"] = comboAA.SelectedIndex.ToString();
                ///Shadow
                data["ScalabilityGroups"]["sg.ShadowQuality"] = comboShadow.SelectedIndex.ToString();
                ///PostProcessing
                data["ScalabilityGroups"]["sg.PostProcessQuality"] = comboPostProcessing.SelectedIndex.ToString();
                ///Texture
                data["ScalabilityGroups"]["sg.TextureQuality"] = comboTexture.SelectedIndex.ToString();
                ///Effects
                data["ScalabilityGroups"]["sg.EffectsQuality"] = comboEffects.SelectedIndex.ToString();
                ///Foliage
                data["ScalabilityGroups"]["sg.FoliageQuality"] = comboFoliage.SelectedIndex.ToString();
                parser.WriteFile(configFilePath, data);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            Properties.Settings.Default.ResolutionID = boxResolution.SelectedIndex;
            Properties.Settings.Default.EnabledVSync = boxVSync.Checked;
            Properties.Settings.Default.EnableDynamicResolution = boxDynamicResolution.Checked;
            Properties.Settings.Default.FPSLimit = comboFPS.SelectedIndex;
            Properties.Settings.Default.ScreenModeID = comboScreenMode.SelectedIndex;
            Properties.Settings.Default.ViewDistanceID = comboViewDistance.SelectedIndex;
            Properties.Settings.Default.AAID = comboAA.SelectedIndex;
            Properties.Settings.Default.PostID = comboPostProcessing.SelectedIndex;
            Properties.Settings.Default.ShadowID = comboShadow.SelectedIndex;
            Properties.Settings.Default.TextureID = comboTexture.SelectedIndex;
            Properties.Settings.Default.EffectsID = comboEffects.SelectedIndex;
            Properties.Settings.Default.FoliageID = comboFoliage.SelectedIndex;
            Properties.Settings.Default.Save();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
