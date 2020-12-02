using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobileTiltInput : InputBase, IInput
{
    [SerializeField]
    GameObject rotateButtons;

    void Start(){
        rotateButtons.SetActive(false);
    }

    public float GetAcceleration()
    {
        return input.Default.Action.ReadValue<float>();
    }

    public float GetHorizontal()
    {
        return Input.acceleration.x;
    }
}
