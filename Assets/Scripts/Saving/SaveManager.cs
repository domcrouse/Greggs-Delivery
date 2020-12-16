using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveManager : MonoBehaviour
{
    public Slider slider;

    void Start()
    {
        Load();
    }

    public void Load()
    {
        SliderData data = SliderData.Load();
        slider.value = data.sliderVal;
    }

    public void Save()
    {
        SliderData data = new SliderData();
        data.sliderVal = slider.value;

        data.Save();
    }
}
