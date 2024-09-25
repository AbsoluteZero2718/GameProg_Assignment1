using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public int score;

    public void OnTriggerEnter(Collider Ball)
    {
        if (Ball.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            ScoreCounter.instance.IncreaseScore(score);
        }
    }
}
