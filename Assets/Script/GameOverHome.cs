using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverHome : MonoBehaviour
{
    [SerializeField] GameObject gameOverMenu;
    [SerializeField] ScoreScript scoreValue;
    void Start ()
    {
        
    }
    public void Home(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        Time.timeScale = 1;
    }
    public void Restart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        ScoreScript.scoreValue = 0;
        Time.timeScale = 1;
    }
}