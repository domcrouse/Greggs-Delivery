using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class TimerController : MonoBehaviour
{
    public UnityEvent onFail;

    public Text timerDisplayText;
    GameController gameController;
    Coroutine runningTimer = null;

    public int initialTimer = 5;
    private int currentTimer;
    public int endTimer;

    void Start()
    {
        gameController = GetComponent<GameController>();

        runningTimer = StartCoroutine(Countdown());
    }

    void Update()
    {

    }

    public void AddBonusTime(int bonusTime)
    {
        if (!gameController.GameHasEnded)
        {
            currentTimer += bonusTime;

            timerDisplayText.text = "Time remaining: " + currentTimer + " seconds";
        }
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

        onFail.Invoke();

        gameController.EndTheGame();
    }
}
