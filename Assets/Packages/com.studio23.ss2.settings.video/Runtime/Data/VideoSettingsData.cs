using System;
using UnityEngine;

namespace Studio23.SS2.Settings.Video.Data
{
    [Serializable]
    public class VideoSettingsData
    {
        [Header("Video")]
        public int TextureQualityIndex;
        public int VsyncCount;
        public int ShadowType;
        public int ShadowResolutionIndex;

        [Header("Volume")]
        public bool EnableBloom;
        public bool EnableAmbientOcculsion;
    }

}
