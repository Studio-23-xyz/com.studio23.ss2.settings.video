using System;
using Newtonsoft.Json;
using Studio23.SS2.Settings.Video.Core;
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
        [JsonIgnore] public float MinRenderScale;
        [JsonIgnore] public float MaxRenderScale;
        public float RenderScale;
        [JsonIgnore] public float MinBrightnessLevel;
        [JsonIgnore] public float MaxBrightnessLevel;
        public float BrightnessLevel;
        public int VSyncCount;

        [Header("Graphics")]
        public int BloomState;
        public int AmbientOcclusionState;

        public VideoSettingsData() { }

        public VideoSettingsData(int screenModeIndex, int resolutionIndex, float renderScale, float brightnessLevel, int vSyncCount, int bloomState, int ambientOcclusionState)
        {
            ScreenModeIndex = screenModeIndex;
            ResolutionIndex = resolutionIndex;
            RenderScale = renderScale;
            BrightnessLevel = brightnessLevel;
            VSyncCount = vSyncCount;
            BloomState = bloomState;
            AmbientOcclusionState = ambientOcclusionState;
        }

        public VideoSettingsData(VideoSettingsData data)
        {
            ScreenModeIndex = data.ScreenModeIndex;
            ResolutionIndex = data.ResolutionIndex;
            RenderScale = data.RenderScale;
            BrightnessLevel = data.BrightnessLevel;
            VSyncCount = data.VSyncCount;
            BloomState = data.BloomState;
            AmbientOcclusionState = data.AmbientOcclusionState;
        }

    }

}
