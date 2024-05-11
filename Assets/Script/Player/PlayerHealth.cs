using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public int maxHP = 5;
    public int currentHP;
    public HealthBar healthBar;

    private int previousSceneIndex;

    // Start is called before the first frame update
    void Start()
    {
        currentHP = maxHP;
        healthBar.SetMaxHP(maxHP);
        previousSceneIndex = SceneManager.GetActiveScene().buildIndex;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentHP <= 0)
        {
            PlayerPrefs.SetString("PreviousScene", SceneManager.GetActiveScene().name);
            GameOver();
        }
    }

    public void UpdateHP(int value)
    {
        currentHP += value;
        healthBar.UpdateHealthBar(currentHP);
        //Debug.Log(currentHP + "/" + maxHP);
    }

    void GameOver()
    {
        SceneManager.LoadScene(2);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(previousSceneIndex);
    }
}