using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public float jumpForce;
    private bool isJumping = false;
    //public GameObject jumpingCollider;

    private Rigidbody2D rb;
    //private Rigidbody2D jumpCollider;
    private float horizontal;
    private float vertical;
    private float jump;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        //jumpCollider = jumpingCollider.GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
        //jump = Input.GetAxisRaw("Jump");
    }

    private void FixedUpdate()
    {
        if (horizontal > 0.1f || horizontal < -0.1f)
        {
            rb.AddForce(new Vector2(horizontal * speed, 0f), ForceMode2D.Impulse);
        }
        if (vertical > 0.1f || vertical < -0.1f)
        {
            rb.AddForce(new Vector2(0f, vertical * speed), ForceMode2D.Impulse);
        }
        /*
        if (jump > 0.1f && !isJumping)
        {
            rb.AddForce(new Vector2(0f, jump * jumpForce), ForceMode2D.Impulse);
        }
        */

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        /*
        if (collision.gameObject.tag == "Platform") //Prevent double jumping
        {
            isJumping = false;
        }
        */
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        /*
        if (collision.gameObject.tag == "Platform")
        {
            isJumping = true;
        }
        */
    }
}
