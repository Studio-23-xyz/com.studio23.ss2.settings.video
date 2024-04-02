
using UnityEngine;

namespace Studio23.SS2.Settings.Video.Data
{
    [CreateAssetMenu(fileName = "DisplayData", menuName = "Studio-23/Settings/Video/DisplayData", order = 1)]

    public class DisplayData:ScriptableObject
    {
        public int ResolutionIndex;
        public int ScreenModeIndex;
        public float RenderScale;
        public int VSyncCount;
        public float BrightnessLevel;

        public DisplayData(int resolutionIndex, int screenModeIndex, float renderScale, int vSyncCount, float brightnessLevel)
        {
            ResolutionIndex = resolutionIndex;
            ScreenModeIndex = screenModeIndex;
            RenderScale = renderScale;
            VSyncCount = vSyncCount;
            BrightnessLevel = brightnessLevel;
        }
    }
}
