using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicProgressionBar : MonoBehaviour
{
    public AudioSource audioSource; // Assign this in the inspector
    private Slider progressBar;     // This will be the slider component

    void Start()
    {
        progressBar = GetComponent<Slider>();
        progressBar.maxValue = audioSource.clip.length; // Set max value of slider to length of the audio clip
    }

    void Update()
    {
        if (audioSource.isPlaying)
        {
            progressBar.value = audioSource.time; // Update slider value to current audio time
        }
    }
}
