using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    private static int _score;
    [SerializeField] TextMeshProUGUI scoreText;

    private void Update()
    {
        scoreText.text = "Score : " + _score.ToString();
    }

    public static void AddScore(int scoreToAdd)
    {
        _score += scoreToAdd;
    }
}
