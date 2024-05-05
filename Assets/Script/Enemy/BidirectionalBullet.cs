using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BidirectionalBullet : MonoBehaviour
{
    private Vector2 bulletDirection;
    private Rigidbody2D rb;
    public float bulletSpeed;
    public int bulletDamage;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(bulletDirection.x, bulletDirection.y).normalized * bulletSpeed;

        if (transform.position.magnitude > 10.0f) //Destroy the bullet if it gets too far
        {
            Destroy(gameObject);
        }
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            other.gameObject.GetComponent<PlayerHealth>().UpdateHP(-bulletDamage);
        }
    }

    public void SetBulletDirection(Vector2 dir)
    {
        bulletDirection = dir;
    }
}
