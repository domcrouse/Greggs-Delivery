using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerController : MonoBehaviour
{
    private int initialTimer = 3;
    public int currentTimer;
    public Text timerDisplayText;

    void Start()
    {
        StartCoroutine(Countdown());
    }

    void Update()
    {
        
    }

    IEnumerator Countdown()
    {
        currentTimer = initialTimer;
        timerDisplayText.text = "You have " + initialTimer + " seconds";

        while (currentTimer > 0)
        {
            yield return new WaitForSeconds(1);
            currentTimer--;
            timerDisplayText.text = "Time remaining: " + currentTimer + " seconds";
        }
    }
}
