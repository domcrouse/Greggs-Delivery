using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slidercontroller : MonoBehaviour
{
    public Slider slider;

    public float sliderVal;

    public void Start()
    {
        slider.value = PlayerPrefs.GetFloat("save", sliderVal);
    }

    public void sliderchange(float value)
    {
        sliderVal = value;
        PlayerPrefs.SetFloat("save", sliderVal);
    }
}
