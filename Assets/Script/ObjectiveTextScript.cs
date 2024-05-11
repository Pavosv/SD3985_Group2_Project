using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ObjectiveTextScript : MonoBehaviour
{
    private TextMeshProUGUI objectiveText;
    public static int levelNumber;
    public static int winScore;
    public GameObject winCondition;

    // Start is called before the first frame update
    void Start()
    {
        levelNumber = winCondition.GetComponent<WinCondition>().levelNumber;
        winScore = winCondition.GetComponent<WinCondition>().winScore;
        objectiveText = GetComponent<TextMeshProUGUI>();
        objectiveText.text = "Level " + levelNumber + " - " + winScore;
    }
}
