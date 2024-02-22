using Studio23.SS2.Settings.Video.Core;
using System.Collections.Generic;
using UnityEngine;

namespace Studio23.SS2.Settings.Video.Samples
{
    public class DisplayUI : MonoBehaviour
    {
        [SerializeField] private DisplayController displayController;

        [SerializeField] private LoopedStepper _preset;
        [SerializeField] private LoopedStepper _Resolutionstepper;
        [SerializeField] private LoopedStepper _displayModeStepper;
        [SerializeField] private LoopedStepper _vSyncStepper;
        [SerializeField] private LoopedStepper _shadowStepper;
        [SerializeField] private LoopedStepper _shadowResolution;
        [SerializeField] private LoopedStepper _textureQuality;

        private void Start()
        {
            InitializeUI();
        }


        private void InitializeUI()
        {
            _preset.InitializeData(new List<string>() { "High", "Medium", "Low", "Custom" });
            _Resolutionstepper.InitializeData(displayController.GetSupportedResolutions(), displayController.GetSelectedResoltuonIndex());
            _displayModeStepper.InitializeData(displayController.GetFullScreenModes());
            _vSyncStepper.InitializeData(new List<string>() { "Off", "On", "Every 2nd V-Blank" });
            _shadowStepper.InitializeData(displayController.GetShadowType());
            _shadowResolution.InitializeData(displayController.GetShadowResolutions());
            _textureQuality.InitializeData(new List<string>() { "Full", "Half", "Quarter", "Eighth" });

        }



    }
}

