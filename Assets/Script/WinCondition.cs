using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WinCondition : MonoBehaviour
{
    public AudioSource backgroundMusic; // Assign your music source in the Inspector
    public int winScore = 5000; // Set your score criteria for winning the game
    public int levelNumber = 1;
    public float countDown = 5.0f;
    private bool isChecking = false;

    void Update()
    {
        // Check if the music has stopped and we are not already checking
        if (!backgroundMusic.isPlaying && !isChecking)
        {
            StartCoroutine(CheckWinCondition());
            isChecking = true; // Set this to true to prevent multiple checks
        }
    }

    IEnumerator CheckWinCondition()
    {
        // Wait for the countdown
        yield return new WaitForSeconds(countDown);

        int currentScore = GetPlayerScore();
        CheckScore(currentScore);
        isChecking = false;
    }

    public void CheckScore(int currentScore)
    {
        if (currentScore >= winScore)
        {
            WinGame();
        }
        else
        {
            LoseGame();
        }
    }

    public int GetPlayerScore()
    {
        // Access score value from the ScoreScript
        return ScoreScript.scoreValue;
    }

    public void WinGame()
    {
        // Load the winning screen
        Debug.Log("You won");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        
    }

    public void LoseGame()
    {
        // Load the game over scene
        SceneManager.LoadScene(13);
    }
}
