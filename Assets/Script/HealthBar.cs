using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider slider;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetMaxHP(int HP)
    {
        slider.maxValue = HP;
        slider.value = HP;
    }
    public void UpdateHealthBar(int HP)
    {
        slider.value = HP;
    }
}
