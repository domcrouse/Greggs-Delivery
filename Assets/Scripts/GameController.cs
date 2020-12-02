using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    Scene highscoreScene;

    TimerController timerController;
    public Text scoreDisplayText;

    private int currentScore = 0;
    public int endScore = -1;
    public bool GameHasEnded = false;

    void Start()
    {
        timerController = GetComponent<TimerController>();
        scoreDisplayText.text = "Score: " + currentScore;
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
        if (Input.GetKeyDown(KeyCode.T))
        {
            timerController.AddBonusTime(5);
        }
    }

    public void AddScore(int points)
    {
        if (!GameHasEnded)
        {
            currentScore += points;
            scoreDisplayText.text = "Score: " + currentScore;
        }
    }

    //Amount of points gained from remaining timer
    int TimerBonusPoints(int remainingTimer)
    {
        int bonusPoints = remainingTimer * 10;

        return bonusPoints;
    }

    //When player completes objective
    public void EndTheGame()
    {
        timerController.StopTimer();

        AddScore(TimerBonusPoints(timerController.endTimer));

        endScore = currentScore;
        scoreDisplayText.text = "You have achieved a score of: " + endScore;

        GameHasEnded = true;

        Highscores.AddNewHighscore("Kin", endScore);
    }

    //public static void 
}
