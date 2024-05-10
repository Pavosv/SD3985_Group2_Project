using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    public float scrollSpeed;

    private Vector3 startPosition;
    private float imageWidth;

    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
        RectTransform rectTransform = GetComponent<RectTransform>();
        imageWidth = rectTransform.rect.width;
    }

    // Update is called once per frame
    void Update()
    {
        float newPosition = Mathf.Repeat(Time.time * scrollSpeed, imageWidth);
        transform.position = startPosition + Vector3.left * newPosition;
    }
}
