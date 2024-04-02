
using UnityEngine;

namespace Studio23.SS2.Settings.Video.Data
{
    [CreateAssetMenu(fileName = "GraphicsData", menuName = "Studio-23/Settings/Video/GraphicsData", order = 1)]
    public class GraphicsData :ScriptableObject
    {
        public bool AmbientOcclusionState;
        public bool BloomState;

        public GraphicsData(bool ambientOcclusionState, bool bloomState)
        {
            AmbientOcclusionState = ambientOcclusionState;
            BloomState = bloomState;
        }
    }
}