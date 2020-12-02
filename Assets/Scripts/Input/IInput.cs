using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IInput
{
    float GetHorizontal(); // float from -1, to 1 for the horizontal axis

    float GetAcceleration(); // float from -1, to 1 for acceleration/reverse
}
