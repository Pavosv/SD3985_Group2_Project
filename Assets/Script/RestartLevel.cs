using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartLevel : MonoBehaviour
{
    private int previousSceneIndex;
    private int requiredSceneIndex;

    void Start()
    {
        previousSceneIndex = PlayerPrefs.GetInt("PreviousSceneIndex");
        requiredSceneIndex = previousSceneIndex - 1;
        Debug.Log("Previous Scene Index: " + previousSceneIndex);
    }

    public void Restart()
    {
        SceneManager.LoadScene(previousSceneIndex);
    }
<<<<<<< Updated upstream
=======

    public void Home()
    {
        if (requiredSceneIndex >= 0 && requiredSceneIndex < SceneManager.sceneCountInBuildSettings)
        {
            SceneManager.LoadScene(requiredSceneIndex);
        }
        else
        {
            Debug.LogWarning("Invalid scene index: " + requiredSceneIndex);
        }
    }
>>>>>>> Stashed changes
}