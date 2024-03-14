using System.IO;
using Studio23.SS2.Settings.Video.Data;
using UnityEditor;
using UnityEngine;

namespace Studio23.SS2.Settings.Video.Editor
{
    public class DummyGraphicsConfigurationEditor : MonoBehaviour
    {
        [MenuItem("Studio-23/Settings/Video/DummyGraphicsConfiguration", false, 10)]
        static void CreateDefaultProvider()
        {
            DummyGraphicsConfiguration graphicsProviderConfig = ScriptableObject.CreateInstance<DummyGraphicsConfiguration>();

            // Create the resource folder path
            string resourceFolderPath = "Assets/Resources/Settings/Video/PostProcess";

            if (!Directory.Exists(resourceFolderPath))
            {
                Directory.CreateDirectory(resourceFolderPath);
            }

            // Create the ScriptableObject asset in the resource folder
            string assetPath = resourceFolderPath + "/DummyGraphicsConfiguration.asset";
            AssetDatabase.CreateAsset(graphicsProviderConfig, assetPath);
            AssetDatabase.SaveAssets();
            AssetDatabase.Refresh();

            Debug.Log("Post Process Base created at: " + assetPath);
        }
    }

}