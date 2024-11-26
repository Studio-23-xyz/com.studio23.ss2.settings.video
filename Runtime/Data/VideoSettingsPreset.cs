using UnityEngine;


namespace Studio23.SS2.Settings.Video.Data
{
    [CreateAssetMenu(fileName = "Video Settings Preset", menuName = "Studio-23/Settings/Video/Settings Preset", order = 1)]
    public class VideoSettingsPreset : ScriptableObject
    {
        public string PresetName;
        public VideoSettingsData Data;
    }

}

