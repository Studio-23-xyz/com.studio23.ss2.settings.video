using System;
using System.Collections.Generic;
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


        public int BloomState;
        public int AmbientOcclusionState;

        [Header("Graphics - Quality")] 
        public int MinQualitySettingIndex;
        public int MaxQualitySettingIndex;
        public int CurrentQualitySettingIndex;

        [Header("Graphics - Shadow")]
        public int MinShadowSettingIndex;
        public int MaxShadowSettingIndex;
        public int CurrentShadowSettingIndex;

        [Header("Graphics - Texture")]
        public int MinTextureSettingIndex;
        public int MaxTextureSettingIndex;
        public int CurrentTextureSettingIndex;

        [Header("Preset Settings")]
        public List<PresetSettingsData> PresetSettingsData;
        

        public VideoSettingsData() { }

        public VideoSettingsData(int screenModeIndex, int resolutionIndex,float minRender, float maxRender, float renderScale, float minBrightness, float maxBrightness, float brightnessLevel, int vSyncCount, int bloomState, int ambientOcclusionState, int currentQualitySettingIndex, int currentShadowSettingIndex, int maxTextureSettingIndex, int currentTextureSettingIndex, List<PresetSettingsData> presetData)
        {
            ScreenModeIndex = screenModeIndex;
            ResolutionIndex = resolutionIndex;
            RenderScale = renderScale;
            BrightnessLevel = brightnessLevel;
            VSyncCount = vSyncCount;


            MinRenderScale = minRender;
            MaxRenderScale = maxRender;
            MinBrightnessLevel = minBrightness;
            MaxBrightnessLevel = maxBrightness;

            BloomState = bloomState;
            AmbientOcclusionState = ambientOcclusionState;
            CurrentQualitySettingIndex = currentQualitySettingIndex;
            CurrentShadowSettingIndex = currentShadowSettingIndex;
            MaxTextureSettingIndex = maxTextureSettingIndex;
            CurrentTextureSettingIndex = currentTextureSettingIndex;

            PresetSettingsData = presetData;
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
            CurrentQualitySettingIndex = data.CurrentQualitySettingIndex;
            CurrentShadowSettingIndex = data.CurrentShadowSettingIndex;
            CurrentTextureSettingIndex = data.CurrentTextureSettingIndex;
            PresetSettingsData = data.PresetSettingsData;
            MinShadowSettingIndex = data.MinShadowSettingIndex;
            MaxShadowSettingIndex = data.MaxShadowSettingIndex;
            MinQualitySettingIndex = data.MinQualitySettingIndex;
            MaxQualitySettingIndex = data.MaxQualitySettingIndex;
            MinTextureSettingIndex = data.MinTextureSettingIndex;
            MaxTextureSettingIndex = data.MaxTextureSettingIndex;
        }

    }

    [System.Serializable]
    public class PresetSettingsData
    {
        public int QualitySettingsIndex;
        public int ShadowSettingsIndex;
        public int TextureSettingsIndex;
    }

}
