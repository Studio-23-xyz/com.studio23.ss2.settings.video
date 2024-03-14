
using Studio23.SS2.Settings.Video.Core;
using Studio23.SS2.Settings.Video.Data;
using UnityEngine;
using UnityEngine.Rendering;

namespace Studio23.SS2.Settings.Video.Core
{
    public class VideoSettingsManager : MonoBehaviour
    {
        public static VideoSettingsManager Instance; 
        public DisplayController DisplayController;
        public GraphicsController GraphicsController;

        [SerializeField] private Volume _globalVolume;
        [SerializeField] private GraphicsConfigurationBase _postProcessConfiguration;

        private void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
                DontDestroyOnLoad(this);
            }
            else 
                Destroy(this);
        }

        private void Start()
        {
            Initialize();
        }


        public void Initialize()
        {
            if(_globalVolume == null)
                _globalVolume = GameObject.FindGameObjectWithTag("GlobalVolume").GetComponent<Volume>();
            if (_postProcessConfiguration == null)
                _postProcessConfiguration = Resources.Load<GraphicsConfigurationBase>("Settings/Video/PostProcess/DummyPostProcess");
            DisplayController.Initialize(_postProcessConfiguration,_globalVolume);
            GraphicsController.Initialize(_postProcessConfiguration,_globalVolume);
        }


    }
}
