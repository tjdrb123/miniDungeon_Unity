using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;


public class LevelBarController : MonoBehaviour
{
    private PlayerDatasSO playerDatas;

    private Slider slider;
    private Text text;

    private void Start()
    {
        //slider.onValueChanged.AddListener(UpdateText);
    }

    public void UpdateText(float value)
    {
       // text.text = "Slider Value: " + value;
    }
}
    
