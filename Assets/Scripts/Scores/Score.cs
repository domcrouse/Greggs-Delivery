using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public int score;
    public Text scoreText;

    public void AddScore(int toAdd)
    {
        score += toAdd;
        scoreText.text = "Score: " + score;
    }
}
