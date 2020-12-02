using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobileInput : InputBase, IInput
{
    public float GetAcceleration()
    {
        return input.Default.Action.ReadValue<float>();
    }

    public float GetHorizontal()
    {
        return input.Default.Horizontal.ReadValue<float>();
    }
}
