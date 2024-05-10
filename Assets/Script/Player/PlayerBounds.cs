using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBounds : MonoBehaviour
{
    private Vector2 screenBounds;
    private float playerWidth;
    private float playerHeight;

    // Start is called before the first frame update
    void Start()
    {
        Collider2D collider = GetComponent<Collider2D>();
        playerWidth = collider.bounds.extents.x;
        playerHeight = collider.bounds.extents.y;

        Camera mainCamera = Camera.main;
        float camHeight = 2f * mainCamera.orthographicSize;
        float camWidth = camHeight * mainCamera.aspect;
        screenBounds = new Vector2(camWidth, camHeight) /2;
    }

    void LateUpdate()
    {
        Vector3 playerPos = transform.position;
        playerPos.x = Mathf.Clamp(playerPos.x, -screenBounds.x + playerWidth, screenBounds.x - playerWidth);
        playerPos.y = Mathf.Clamp(playerPos.y, -screenBounds.y + playerHeight, screenBounds.y - playerHeight);
        transform.position = playerPos;
    }
}
