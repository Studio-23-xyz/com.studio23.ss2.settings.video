using Studio23.SS2.Settings.Video.Data;
using System;
using UnityEngine;
using UnityEngine.Rendering;

namespace Studio23.SS2.Settings.Video.Core
{
    public class GraphicsController : MonoBehaviour
    {
        private GraphicsConfigurationBase _postProcessData;

        public void Initialize(GraphicsConfigurationBase graphicsConfiguration,Volume volume)
        {
            _postProcessData = graphicsConfiguration;
            _postProcessData.Initialize(volume);
        }

        /// <summary>
        /// Enable Or Disable Bloom
        /// </summary>
        /// <param name="stateIndex"></param>
        public void SetBloomState(int stateIndex)
        {
            _postProcessData.SetBloomState(stateIndex > 0);
        }

        /// <summary>
        /// Enable Or Disable Ambient Occulsion
        /// </summary>
        /// <param name="stateIndex"></param>
        public void SetAmbientOcculsionState(int stateIndex)
        {
            _postProcessData.SetAmbientOcclusionState(stateIndex > 0);
        }

        /// <summary>
        /// Changes Texture Quality Settings while 0 is the highest and 3 is the lowest
        /// 0=full , 1=half , 2=quarter , 3=eighth
        /// </summary>
        /// <param name="quality"></param>
        public void ChangeTextureQuality(int quality)
        {
            QualitySettings.globalTextureMipmapLimit = quality;
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


        /// <summary>
        /// Change Game Quality Settings
        /// </summary>
        /// <param name="qualitySetting"></param>
        public void ChangeQualitySetting(int qualitySetting)
        {
            QualitySettings.SetQualityLevel(qualitySetting, true);
        }
    }
}