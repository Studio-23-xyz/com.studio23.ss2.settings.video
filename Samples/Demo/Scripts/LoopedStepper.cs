using System;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LoopedStepper : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI DisplayText;
    [SerializeField] private Button _leftButton;
    [SerializeField] private Button _rightButton;

    [SerializeField]private int _selectedIndex;
    private IList _data;


    private void Start()
    {
        _leftButton.onClick.AddListener(Left);
        _rightButton.onClick.AddListener(Right);
    }

    public void InitializeData(IList data,int selectIndex=0)
    {
        _selectedIndex = selectIndex;
        _data = data;
        ShowText();
    }


    private void ShowText()
    {
        DisplayText.text = _data[_selectedIndex].ToString();
    }

    public void Right()
    {
        if(_selectedIndex < _data.Count-1)
        {
            _selectedIndex++;
        }
        else
        {
            _selectedIndex = 0;
        }

        ShowText();
    }


    public void Left()
    {
        if (_selectedIndex > 0)
        {
            _selectedIndex--;
        }
        else
        {
            _selectedIndex = _data.Count-1;
        }
        ShowText() ;
    }


}
