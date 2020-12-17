using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MouseDownEvent : MonoBehaviour
{
    [SerializeField]
    UnityEvent onMouseDown;

    void OnMouseDown(){
        onMouseDown.Invoke();
    }
}
