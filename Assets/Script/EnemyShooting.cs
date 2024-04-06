using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    public GameObject bullet;
    public Transform bulletpos;
    public int damage = 1;
    public float fireRate = 2;

    private float timer;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer > fireRate)
        {
            timer = 0;
            shoot();
        }
    }

    public void shoot()
    {
        GameObject instantiatedBullet = Instantiate(bullet, bulletpos.position, Quaternion.identity);
        instantiatedBullet.gameObject.GetComponent<EnemyBulletScript>().bulletDamage = damage;
    }
}
