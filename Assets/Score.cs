using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public TextMeshProUGUI ScoreText;
    private int currentScore = 0;
    public int GetScore(){
        return currentScore;
    }

    void Update(){
        ScoreText.text = currentScore.ToString();
    }
    public void AddScore(){
        currentScore++;
    }
}
