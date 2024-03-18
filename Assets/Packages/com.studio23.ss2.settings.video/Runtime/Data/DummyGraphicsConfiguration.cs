
using UnityEngine;
using UnityEngine.Rendering;

namespace Studio23.SS2.Settings.Video.Data
{
    public class DummyGraphicsConfiguration : GraphicsConfigurationBase
    {
        public override void Initialize(Volume currentVolume)
        {
            Debug.Log($"{name}: <color=green>Volume found</color>");
        }

        public override void SetBloomState(bool state)
        {
            Debug.Log($"{name}: <color=green>Updated bloom value</color>");
        }

        public override void SetAmbientOcclusionState(bool state)
        {
            Debug.Log($"{name}: <color=green>Updated ambient occulusion value</color>");
        }

        public override void SetBrightness(float brightnessValue)
        {
            Debug.Log($"{name}: <color=green>Updated brightness value</color>");
        }

        public override void UpdateAmbientOcclusionRenderFeature()
        {
            Debug.Log($"{name}: <color=green>Updated AO value</color>");
        }
    }
}
