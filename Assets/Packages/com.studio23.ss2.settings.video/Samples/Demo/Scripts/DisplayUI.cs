using Studio23.SS2.Settings.Video.Core;
using System.Linq;
using UnityEngine;


public class DisplayUI : MonoBehaviour
{
    [SerializeField]private DisplayController displayController;

    [SerializeField]private LoopedStepper _Resolutionstepper;


    private void Start()
    {
        InitializeUI();
    }


    private void InitializeUI()
    {

        _Resolutionstepper.InitializeData(displayController.GetSupportedResolutions(), displayController.GetSelectedResoltuonIndex());


    }



}
