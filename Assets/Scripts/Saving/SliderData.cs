using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;


[System.Serializable]
public class SliderData
{
    public float sliderVal = 1f;

    public static SliderData Load()
    {
        string filePath = Application.persistentDataPath + "/SliderVal.json";

        if(File.Exists(filePath))
        {
            string json = File.ReadAllText(filePath);
            return JsonUtility.FromJson<SliderData>(json);
        }
        else
        {
            return new SliderData();
        }
    }

    public void Save()
    {
        string filePath = Application.persistentDataPath + "/SliderVal.json";

        string json = JsonUtility.ToJson(this);
        File.WriteAllText(filePath, json);
    }
}



