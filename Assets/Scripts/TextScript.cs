﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextScript : MonoBehaviour
{
    [SerializeField]
    public Text scoreText;
    int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        CollectorScript.Score += IncreaseScore;
    }

    void IncreaseScore()
    {
        score++;
        scoreText.text = "Score: " + score;
    }

}
