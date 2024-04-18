using System;
using UnityEngine;

namespace Studio23.SS2.Settings.Video.Data
{
    [CreateAssetMenu(fileName = "VideoSettingsData", menuName = "Studio-23/Settings/Video/VideoSettingsData", order = 1)]
    [Serializable]
    public class VideoSettingsData : ScriptableObject
    {
        [Header("Display")]
        public int ScreenModeIndex;
        public int ResolutionIndex;
        public float MinRenderScale;
        public float MaxRenderScale;
        public float RenderScale;
        public float MinBrightnessLevel;
        public float MaxBrightnessLevel;
        public float BrightnessLevel;
        public int VSyncCount;

        [Header("Graphics")]
        public int BloomState;
        public int AmbientOcclusionState;

        public VideoSettingsData() { }

        public VideoSettingsData(int screenModeIndex, int resolutionIndex,float minRender, float maxRender, float renderScale, float minBrightness, float maxBrightness, float brightnessLevel, int vSyncCount, int bloomState, int ambientOcclusionState)
        {
            ScreenModeIndex = screenModeIndex;
            ResolutionIndex = resolutionIndex;
            RenderScale = renderScale;
            BrightnessLevel = brightnessLevel;
            VSyncCount = vSyncCount;
            BloomState = bloomState;
            AmbientOcclusionState = ambientOcclusionState;

            MinRenderScale = minRender;
            MaxRenderScale = maxRender;
            MinBrightnessLevel = minBrightness;
            MaxBrightnessLevel = maxBrightness;
        }

        public VideoSettingsData(VideoSettingsData data)
        {
            ScreenModeIndex = data.ScreenModeIndex;
            ResolutionIndex = data.ResolutionIndex;
            MinRenderScale = data.MinRenderScale;
            MaxRenderScale = data.MaxRenderScale;
            RenderScale = data.RenderScale;
            MinBrightnessLevel = data.MinBrightnessLevel;
            MaxBrightnessLevel = data.MaxBrightnessLevel;
            BrightnessLevel = data.BrightnessLevel;
            VSyncCount = data.VSyncCount;
            BloomState = data.BloomState;
            AmbientOcclusionState = data.AmbientOcclusionState;
        }

    }

}
