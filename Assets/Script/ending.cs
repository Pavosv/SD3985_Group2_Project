using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class ending : MonoBehaviour
{
    public VideoPlayer videoPlayer;

    private bool videoEnded = false;

    void Start()
    {
        videoPlayer.loopPointReached += OnVideoEnd;
    }

    void Update()
    {
        if (!videoEnded && (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.Space)))
        {
            OnVideoEnd(videoPlayer);
        }
    }

    void OnVideoEnd(VideoPlayer vp)
    {
        if (!videoEnded)
        {
            videoEnded = true;
            SceneManager.LoadScene(10);
        }
    }
}