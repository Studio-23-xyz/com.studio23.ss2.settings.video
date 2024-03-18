
using UnityEngine;
using UnityEngine.Rendering;

namespace Studio23.SS2.Settings.Video.Data
{
    public abstract class GraphicsConfigurationBase : ScriptableObject
    {
        protected VolumeProfile CurrentVolumeProfile;


        /// <summary>
        ///Initialize volume profile to change settings 
        /// </summary>
        public abstract void Initialize(Volume currentVolume);


        /// <summary>
        /// Enable Or Disable Bloom
        /// </summary>
        /// <param name="state"></param>
        public abstract void SetBloomState(bool state);

        /// <summary>
        /// Enable Or Disable Ambient Occulsion
        /// </summary>
        /// <param name="state"></param>
        public abstract void SetAmbientOcclusionState(bool state);

        /// <summary>
        /// Update Brightness
        /// </summary>
        /// <param name="brightnessValue"></param>
        public abstract void SetBrightness(float brightnessValue);


        /// <summary>
        /// Update Ambient Occulsion Render Feature when graphics changes
        /// </summary>
        public abstract void UpdateAmbientOcclusionRenderFeature();
    }
}
