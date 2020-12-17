using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveManager : MonoBehaviour
{
    public Slider slider;

    void Awake()
    {
        Load();
    }

    public void Load()
    {
        SliderData data = SliderData.Load();
        if(slider != null){
            slider.value = data.sliderVal;
            SliderData.currentVolume = slider.value;
        }
        AudioListener.volume = SliderData.currentVolume;
    }

    public void Save()
    {
        SliderData data = new SliderData();
        data.sliderVal = slider.value;

        data.Save();
    }
}
