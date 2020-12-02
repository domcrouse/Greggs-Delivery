using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerController : MonoBehaviour
{
    private int initialTimer = 5;
    public int currentTimer;
    public Text timerDisplayText;

    Coroutine runningTimer = null;

    void Start()
    {
        runningTimer = StartCoroutine(Countdown());
    }

    void Update()
    {
        //Debug button
        if (Input.GetKeyDown(KeyCode.E))
        {
            StopCoroutine(runningTimer);
        }
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

        Debug.Log("Timer has ended.");
    }
}
