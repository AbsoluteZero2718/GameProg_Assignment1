using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreCounter : MonoBehaviour
{
    public static ScoreCounter instance;

    public TMP_Text scoreText;
    public int currentScore = 0;

    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        scoreText.text = "Score: " + currentScore.ToString();
    }

    public void IncreaseScore(int s)
    {
        currentScore += s;
        scoreText.text = "Score: " + currentScore.ToString();

    }
}
