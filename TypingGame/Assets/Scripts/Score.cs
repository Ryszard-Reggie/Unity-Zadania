using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static Score instance;
    
    public Text scoreText;
    public Text highestScoreText;

    private int score = 0;
    private int highestScore = 0;

    private void Awake()
    {
        instance = this;
    }

    public void AddPoints()
    {
        score += 10;
        scoreText.text = score.ToString();
    }

    private void Start()
    {
        scoreText.text = score.ToString();
        highestScoreText.text = highestScore.ToString();
    }

    //private void OnDestroy()
    //{
    //    AddPoints();
    //}

    private void Update()
    {
        scoreText.text = score.ToString();
        highestScoreText.text = score.ToString();
    }
}
