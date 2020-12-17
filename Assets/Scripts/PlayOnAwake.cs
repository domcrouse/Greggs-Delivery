using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayOnAwake : MonoBehaviour
{
    [SerializeField]
    UnityEvent onAwake;
    // Start is called before the first frame update
    void Start()
    {
        onAwake.Invoke();
    }
}
