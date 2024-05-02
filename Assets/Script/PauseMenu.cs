using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu;
    [SerializeField] ScoreScript scoreValue;
    public void Pause(){
        pauseMenu.SetActive(true);
        Time.timeScale = 0;
    }
    public void Home(){
        SceneManager.LoadScene("Main Menu");
        Time.timeScale = 1;
    }
    public void Resume(){
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
    }
    public void Restart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        ScoreScript.scoreValue = 0;
        Time.timeScale = 1;
    }
}
