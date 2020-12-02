using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardInput : InputBase, IInput
{
    [SerializeField]
    GameObject touchControls;

    void Start(){
        touchControls.SetActive(false);
    }

    public float GetAcceleration()
    {
        return input.Default.Action.ReadValue<float>();
    }

    public float GetHorizontal()
    {
        return input.Default.Horizontal.ReadValue<float>();
    }
}
