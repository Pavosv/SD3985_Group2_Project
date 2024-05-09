using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    public GameObject directionalBullet;
    public GameObject bidirectionalBullet;

    public Transform bulletpos;
    public int bulletDamage = 1;
    public float bulletSpeed = 3.0f;
    public int numberOfRadialBullet = 5;

    private float timer;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void ShootAtPlayer()
    {
        GameObject instantiatedBullet = Instantiate(directionalBullet, bulletpos.position, Quaternion.identity);
        instantiatedBullet.gameObject.GetComponent<DirectionalBulletScript>().bulletDamage = bulletDamage;
        instantiatedBullet.gameObject.GetComponent<DirectionalBulletScript>().bulletSpeed = bulletSpeed;
    }

    public void RadialBullet()
    {
        float angleStep = 360f / numberOfRadialBullet;
        float angle = 0f; 

        for (int i = 0; i <= numberOfRadialBullet; i++)
        {
            float projectileXDirection = bulletpos.position.x + Mathf.Sin((angle * Mathf.PI) / 180);
            float projectileYDirection = bulletpos.position.y + Mathf.Cos((angle * Mathf.PI) / 180);

            Vector3 bulletVector = new Vector3(projectileXDirection, projectileYDirection, 0);
            Vector3 bulletDirection = (bulletVector - bulletpos.position);
            GameObject instantiatedBullet = Instantiate(bidirectionalBullet, bulletpos.position, Quaternion.identity);
            instantiatedBullet.gameObject.GetComponent<BidirectionalBullet>().SetBulletDirection(bulletDirection);
            instantiatedBullet.gameObject.GetComponent<BidirectionalBullet>().bulletDamage = bulletDamage;
            instantiatedBullet.gameObject.GetComponent<BidirectionalBullet>().bulletSpeed = bulletSpeed;
            angle += angleStep;
        }
    }
}
