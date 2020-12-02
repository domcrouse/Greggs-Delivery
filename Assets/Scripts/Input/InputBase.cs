using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputBase : MonoBehaviour
{
    protected DefaultInput input;

    void Awake()
    {
        input = new DefaultInput();
        if(Accelerometer.current != null)
            InputSystem.EnableDevice(Accelerometer.current);
    }

    void OnEnable()
    {
        input.Enable();
    }

    void OnDisable()
    {
        input.Disable();
    }
}
