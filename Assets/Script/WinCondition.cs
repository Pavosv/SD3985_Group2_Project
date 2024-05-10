using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinCondition : MonoBehaviour
{
    public AudioSource backgroundMusic; // Assign your music source in the Inspector
    public int winScore = 5000; // Set your score criteria for winning the game

    void Update()
    {
        // Check if the music has stopped playing
        if (!backgroundMusic.isPlaying)
        {
            int currentScore = GetPlayerScore();

            // Check if the player's score is greater than or equal to the win score
            if (currentScore >= winScore)
            {
                WinGame();
            }
            else
            {
                LoseGame();
            }
        }
    }

    int GetPlayerScore()
    {
        // Access score value from the ScoreScript
        return ScoreScript.scoreValue;
    }

    void WinGame()
    {
        // Load the winning screen
        Debug.Log("You won");
    }

    void LoseGame()
    {
        // Load the game over scene
        Debug.Log("Game Over");
    }
}
