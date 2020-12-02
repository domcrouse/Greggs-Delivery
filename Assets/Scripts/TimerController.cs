using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerController : MonoBehaviour
{
    public Text timerDisplayText;
    Coroutine runningTimer = null;

    private int initialTimer = 5;
    private int currentTimer;
    public int endTimer;

    void Start()
    {
        runningTimer = StartCoroutine(Countdown());
    }

    void Update()
    {

    }

    public void StopTimer()
    {
        StopCoroutine(runningTimer);

        endTimer = currentTimer;
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

        Debug.Log("Timer has ran out.");
    }
}
