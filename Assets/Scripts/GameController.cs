using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    TimerController timerController;
    public Text scoreDisplayText;

    private int currentScore = 0;
    public int endScore;

    void Start()
    {
        timerController = GetComponent<TimerController>();
    }

    void Update()
    {
        //Debug buttons
        if (Input.GetKeyDown(KeyCode.E))
        {
            EndTheGame();
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            AddScore(10);
        }
    }

    public void AddScore(int points)
    {
        currentScore += points;
        scoreDisplayText.text = "Score: " + currentScore;
    }

    //Amount of points gained from remaining timer
    int TimerBonusPoints(int remainingTimer)
    {
        int bonusPoints = remainingTimer * 10;

        return bonusPoints;
    }

    //When player completes objective
    void EndTheGame()
    {
        timerController.StopTimer();

        AddScore(TimerBonusPoints(timerController.endTimer));
    }
}
