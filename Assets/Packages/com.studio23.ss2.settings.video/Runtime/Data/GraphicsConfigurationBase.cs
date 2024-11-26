
using UnityEngine;
using UnityEngine.Rendering;

namespace Studio23.SS2.Settings.Video.Data
{
    public abstract class GraphicsConfigurationBase : ScriptableObject
    {

        [SerializeField] protected float _renderScale;
        [SerializeField] protected bool _ambientOccusionEnabled;
        [SerializeField] protected bool _bloomEnabled;

        public float GetCurrentRenderScale => _renderScale;
        public bool  GetCurrentAmbientOcculsion => _ambientOccusionEnabled;
        public bool GetCurrentBloomEnabled => _bloomEnabled;

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
        /// Update Render Scale
        /// </summary>
        /// <param name="scaleValue"></param>
        public abstract void SetRenderScale(float scaleValue);


        /// <summary>
        /// Update Update PipelineRender Asset when graphics changes
        /// </summary>
        public abstract void UpdatePipelineRenderAsset();
    }
}
