using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameManager2 : MonoBehaviour
{
    public Text scoreText;

    int score;
    void Start()
    {
        currentScore(0);
    }

    public void currentScore(int numb)
    {
        score = score + numb;
        scoreText.text = "Score: " + score;
    }
}
