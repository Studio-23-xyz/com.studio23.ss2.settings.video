using Studio23.SS2.Settings.Video.Data;
using System;
using System.Linq;
using UnityEngine;
using UnityEngine.Rendering;

namespace Studio23.SS2.Settings.Video.Core
{
    public class DisplayController : MonoBehaviour
    {

        private GraphicsConfigurationBase _postProcessData;

        public void Initialize(GraphicsConfigurationBase graphicsConfiguration, Volume volume)
        {
            _postProcessData = graphicsConfiguration;
            _postProcessData.Initialize(volume);
        }


        /// <summary>
        /// Use this method to get supported resolutions to show in UI
        /// </summary>
        /// <returns>Array of Resolution struct by Unity</returns>
        public Resolution[] GetSupportedResolutions()
        {
            return Screen.resolutions;
        }

        /// <summary>
        /// Returns the current selected resolution index. Might Need for UI
        /// </summary>
        /// <returns>int</returns>
        public int GetSelectedResolutionIndex()
        {
            return Screen.resolutions.ToList().IndexOf(Screen.currentResolution);
        }

        /// <summary>
        /// Changes The Resolution
        /// </summary>
        /// <param name="resolution"></param>
        public void ChangeResolution(int resolutionIndex)
        {
            UpdateDisplay(GetSupportedResolutions()[resolutionIndex], Screen.fullScreenMode);
        }

        /// <summary>
        /// Use this method to get all the Full Screen Modes to show in UI
        /// </summary>
        /// <returns>Array of Full Screen Mode struct by Unity</returns>
        public FullScreenMode[] GetFullScreenModes()
        {
            return (FullScreenMode[])Enum.GetValues(typeof(FullScreenMode));
        }


        /// <summary>
        /// Changes Full Screen Mode
        /// </summary>
        /// <param name="fullScreenMode"></param>
        public void ChangeFullScreenMode(int fullScreenModeIndex)
        {
            UpdateDisplay(Screen.currentResolution, GetFullScreenModes()[fullScreenModeIndex]);
        }


        private void UpdateDisplay(Resolution resolution,FullScreenMode fullScreenMode)
        {
            Screen.SetResolution(resolution.width, resolution.height,fullScreenMode);
        }

        /// <summary>
        /// Changes VSync. 0 = OFf, 1 = On (60FPS), 2 = Every 2nd V-Blank (30FPS)
        /// </summary>
        /// <param name="count"></param>
        public void ChangeVSync(int count)
        {
            QualitySettings.vSyncCount = count;
        }


        /// <summary>
        /// Update Brightness
        /// </summary>
        /// <param name="brightnessValue"></param>
        public void SetBrightness(float brightnessValue)
        {
            _postProcessData.SetBrightness(brightnessValue);
        }

    }

}

