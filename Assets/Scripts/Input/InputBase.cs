using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputBase : MonoBehaviour
{
    protected DefaultInput input;

    void Awake()
    {
        input = new DefaultInput();
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
