using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public float jumpForce;
    public Sprite mikaFW;
    public Sprite mikaDW;

    private Rigidbody2D rb;
    private SpriteRenderer spriteRenderer;

    private float horizontal;
    private float vertical;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");

        if (vertical < -0.1f || horizontal < -0.1f) 
        {
            spriteRenderer.sprite = mikaDW;
        }
        else
        {
            spriteRenderer.sprite = mikaFW;
        }

    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontal * speed, vertical * speed);
    }
}