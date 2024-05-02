using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loser : MonoBehaviour
{
    public PlayerHealth playerHealth;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (playerHealth.currentHP <= 0)
        {
            gameObject.SetActive(true);
            Time.timeScale = 0;
        }
    }
}