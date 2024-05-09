using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreScript : MonoBehaviour
{
    public static int scoreValue = 0;
    TextMeshProUGUI scoreCounter;
    // Start is called before the first frame update
    void Start()
    {
        scoreValue = 0;
        scoreCounter = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        scoreCounter.text = "Score: " + scoreValue;
    }
}
