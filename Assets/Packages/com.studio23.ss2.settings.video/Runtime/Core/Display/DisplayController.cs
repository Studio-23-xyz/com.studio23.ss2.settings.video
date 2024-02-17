using System;
using System.Linq;
using UnityEngine;

namespace Studio23.SS2.Settings.Video.Core
{
    public class DisplayController : MonoBehaviour
    {


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
        public int GetSelectedResoltuonIndex()
        {
            return Screen.resolutions.ToList().IndexOf(Screen.currentResolution);
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
        public void ChangeFullScreenMode(FullScreenMode fullScreenMode)
        {
            UpdateDisplay(Screen.currentResolution, fullScreenMode);
        }

        /// <summary>
        /// Changes The Resolution
        /// </summary>
        /// <param name="resolution"></param>
        public void ChangeResolution(Resolution resolution)
        {
            UpdateDisplay(resolution, Screen.fullScreenMode);
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
        /// Use this method to get all the Shadow ShadowQuality to show in UI
        /// </summary>
        /// <returns>Array of Shadow ShadowQuality struct by Unity</returns>
        public ShadowQuality[] GetShadowType()
        {
            return (ShadowQuality[])Enum.GetValues(typeof(ShadowQuality));
        }


        /// <summary>
        /// Change Shadow Type
        /// </summary>
        /// <param name="shadowType"></param>
        public void ChangeShadowType(int shadowType)
        {
            QualitySettings.shadows = (ShadowQuality)shadowType;
        }

        /// <summary>
        /// Use this method to get all the Shadow ShadowResolution to show in UI
        /// </summary>
        /// <returns>Array of Shadow Resolution struct by Unity</returns>
        public ShadowResolution[] GetShadowResolutions()
        {
            return (ShadowResolution[])Enum.GetValues(typeof(ShadowResolution));
        }


        /// <summary>
        /// Change Shadow Resolution
        /// </summary>
        /// <param name="shadowResolution"></param>
        public void ChangeShadowResolution(int shadowResolution)
        {
            QualitySettings.shadowResolution = (ShadowResolution)shadowResolution;
        }

    }

}

