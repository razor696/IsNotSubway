using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText;
    public static int scoreCount;
    void Start()
    {
       
    }

    void Update()
    {
        scoreText.text = "Score: " + Mathf.Round(scoreCount);
    }
}
