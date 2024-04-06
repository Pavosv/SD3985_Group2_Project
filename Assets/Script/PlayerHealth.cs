using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHP = 5;
    public int currentHP;
    public HealthBar healthBar;

    // Start is called before the first frame update
    void Start()
    {
        currentHP = maxHP;
        healthBar.SetMaxHP(maxHP);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void updateHP(int value)
    {
        currentHP += value;
        healthBar.UpdateHealthBar(currentHP);
        Debug.Log(currentHP + "/" + maxHP);
    }
}
