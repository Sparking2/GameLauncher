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
            boxResolution.SelectedIndex         = Properties.Settings.Default.ResolutionID;
            boxVSync.Checked                    = Properties.Settings.Default.EnabledVSync;
            boxDynamicResolution.Checked        = Properties.Settings.Default.EnableDynamicResolution;
            comboFPS.SelectedIndex              = Properties.Settings.Default.FPSLimit;
            comboScreenMode.SelectedIndex       = Properties.Settings.Default.ScreenModeID;
            comboViewDistance.SelectedIndex     = Properties.Settings.Default.ViewDistanceID;
            comboAA.SelectedIndex               = Properties.Settings.Default.AAID;
            comboPostProcessing.SelectedIndex   = Properties.Settings.Default.PostID;
            comboShadow.SelectedIndex           = Properties.Settings.Default.ShadowID;
            comboTexture.SelectedIndex          = Properties.Settings.Default.TextureID;
            comboEffects.SelectedIndex          = Properties.Settings.Default.EffectsID;
            comboFoliage.SelectedIndex          = Properties.Settings.Default.FoliageID;
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
                data["/Script/Engine.GameUserSettings"]["bUseVSync"]    = boxVSync.Checked == true ? "True" : "False";
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
                data["ScalabilityGroups"]["sg.ViewDistanceQuality"]     = comboViewDistance.SelectedIndex.ToString();
                ///AA
                data["ScalabilityGroups"]["sg.AntiAliasingQuality"]     = comboAA.SelectedIndex.ToString();
                ///Shadow
                data["ScalabilityGroups"]["sg.ShadowQuality"]           = comboShadow.SelectedIndex.ToString();
                ///PostProcessing
                data["ScalabilityGroups"]["sg.PostProcessQuality"]      = comboPostProcessing.SelectedIndex.ToString();
                ///Texture
                data["ScalabilityGroups"]["sg.TextureQuality"]          = comboTexture.SelectedIndex.ToString();
                ///Effects
                data["ScalabilityGroups"]["sg.EffectsQuality"]          = comboEffects.SelectedIndex.ToString();
                ///Foliage
                data["ScalabilityGroups"]["sg.FoliageQuality"]          = comboFoliage.SelectedIndex.ToString();
                parser.WriteFile(configFilePath, data);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString() + "\n No se encuentra archivo de configuración");
                //throw;
            }

            Properties.Settings.Default.ResolutionID            = boxResolution.SelectedIndex;
            Properties.Settings.Default.EnabledVSync            = boxVSync.Checked;
            Properties.Settings.Default.EnableDynamicResolution = boxDynamicResolution.Checked;
            Properties.Settings.Default.FPSLimit                = comboFPS.SelectedIndex;
            Properties.Settings.Default.ScreenModeID            = comboScreenMode.SelectedIndex;
            Properties.Settings.Default.ViewDistanceID          = comboViewDistance.SelectedIndex;
            Properties.Settings.Default.AAID                    = comboAA.SelectedIndex;
            Properties.Settings.Default.PostID                  = comboPostProcessing.SelectedIndex;
            Properties.Settings.Default.ShadowID                = comboShadow.SelectedIndex;
            Properties.Settings.Default.TextureID               = comboTexture.SelectedIndex;
            Properties.Settings.Default.EffectsID               = comboEffects.SelectedIndex;
            Properties.Settings.Default.FoliageID               = comboFoliage.SelectedIndex;
            Properties.Settings.Default.Save();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
