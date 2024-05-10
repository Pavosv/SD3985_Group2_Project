using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public AudioSource music;
    public bool startPlaying = false;

    //public BeatScroller BS;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if (!startPlaying)
        {
            if (Input.anyKeyDown)
            {
                startPlaying = true;
                //BS.hasStarted = true;

                music.Play();
            }
        } 
    }
}
