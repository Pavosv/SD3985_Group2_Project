using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class finishMenu : MonoBehaviour
{
    public void nextStage(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void mainMenu(){
        SceneManager.LoadScene(0);
    }
}