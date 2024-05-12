using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartLevel : MonoBehaviour
{
    private string previousSceneName;

    void Start()
    {
        previousSceneName = PlayerPrefs.GetString("PreviousScene");
    }

    public void Restart()
    {
        SceneManager.LoadScene(previousSceneName);
    }
    public void Home(){
        SceneManager.LoadScene(0);
    }
}