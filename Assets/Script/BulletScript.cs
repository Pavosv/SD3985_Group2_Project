using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    private Vector3 mousePosition;
    private Camera mainCamera;
    private Rigidbody2D rb;
    public float bulletSpeed;
    public int damage;

    // Start is called before the first frame update
    void Start()
    {
        mainCamera = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
        rb = GetComponent<Rigidbody2D>();

        mousePosition = mainCamera.ScreenToWorldPoint(Input.mousePosition);
        Vector3 direction = mousePosition- transform.position;
        Vector3 rotation = transform.position - mousePosition;
        rb.velocity = new Vector2(direction.x, direction.y).normalized * bulletSpeed; //Normalize so that the bullet will not change speed regardless if cursor is far
        float rot = Mathf.Atan2(rotation.y, rotation.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, rot + 180);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.magnitude > 10.0f) //Destroy the bullet if it gets too far
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
        ScoreScript.scoreValue += damage;
    }
}
