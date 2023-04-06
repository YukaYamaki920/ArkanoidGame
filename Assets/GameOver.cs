using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public Score Score;
    public TextMeshProUGUI ScoreValue;
    public GameObject gameOverMenu;
    public void ShowGameOverMenu(){
        gameOverMenu.SetActive(true);
        ScoreValue.text = Score.GetScore().ToString();
        Time.timeScale = 0;
    }
    public void Restart(){
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }
    public void Quit(){
        Application.Quit();
    }
}
