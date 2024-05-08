using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class BulletPattern : MonoBehaviour
{
    public GameObject bullet;
    public Transform[] spawnPoint;

    public int bulletDamage;
    public float bulletSpeed;
    public float bpm = 120.0f;
    private float spawnInterval;

    private Action[] sequence;
    private int currentSequence = 0;

    public void Start()
    {
        spawnInterval = 60.0f / bpm;

        sequence = new Action[]
        {
            TopBottom,
            Middle,
            TopBottom,
            Middle,
            TopBottom,
            Middle,
            TopBottom,
            Slash,
            Backslash,
            Slash,
            Backslash,
            Arrow,
            TopArrow,
            BottomArrow,
            LongArrow,
            Slash,
            Backslash,
            TopArrow,
            BottomArrow,
            Backslash,
            Slash,
            Backslash,
            Diamond,

            Blank,
            TopBottom,
            Middle,
            TopBottom,
            Middle,
            TopBottom,
            Middle,
            TopBottom,
            Backslash,
            Slash,
            TopArrow,
            BottomArrow,
            LongArrow,
            LongArrow,
            TopBottom,
            Diamond,
            
            Blank,
            Middle,
            Slash,
            Backslash,
            Slash,
            TopBottom,
            Middle,
            Diamond,

            Blank,
            Arrow,
            TopArrow,
            BottomArrow,
            LongArrow,
            Slash,
            Backslash,
            Diamond,

            Blank,
            TopBottom,
            Middle,
            TopBottom,
            Middle,
            TopBottom,
            Middle,
            TopBottom,
            Middle,
            Diamond,
            Ending,
            Ending,
        };
    }

    public void StartSequence()
    {
        if (currentSequence >= 0 && currentSequence < sequence.Length)
        {
            sequence[currentSequence]();
            currentSequence++;
        }
    }

    public void Arrow()
    {
        StartCoroutine(ArrowCoroutine());
    }
    public void TopArrow()
    {
        StartCoroutine(TopArrowCoroutine());
    }

    public void BottomArrow()
    {
        StartCoroutine(BottomArrowCoroutine());
    }
    public void LongArrow()
    {
        StartCoroutine(LongArrowCoroutine());
    }
    public void Diamond()
    {
        StartCoroutine(DiamondCoroutine());
    }
    public void Slash()
    {
        StartCoroutine(SlashCoroutine());
    }

    public void Backslash()
    {
        StartCoroutine(BackslashCoroutine());
    }

    public void TopBottom()
    {
        StartCoroutine(TopBottomCoroutine());
    }

    public void Middle()
    {
        StartCoroutine(MiddleCoroutine());
    }

    public void Ending()
    {
        StartCoroutine(EndingCoroutine());
    }
    public void Blank()
    {

    }

    IEnumerator TopArrowCoroutine()
    {
        SpawnBullet(spawnPoint[1]);
        yield return new WaitForSeconds(spawnInterval);
        SpawnBullet(spawnPoint[0]);
        SpawnBullet(spawnPoint[2]);
    }

    IEnumerator BottomArrowCoroutine()
    { 
        SpawnBullet(spawnPoint[3]);
        yield return new WaitForSeconds(spawnInterval);
        SpawnBullet(spawnPoint[2]);
        SpawnBullet(spawnPoint[4]);
    }

    IEnumerator ArrowCoroutine()
    {
        SpawnBullet(spawnPoint[2]);
        yield return new WaitForSeconds(spawnInterval);
        SpawnBullet(spawnPoint[1]);
        SpawnBullet(spawnPoint[3]);
        
    }
    IEnumerator LongArrowCoroutine()
    {
        SpawnBullet(spawnPoint[2]);
        yield return new WaitForSeconds(2 * spawnInterval);
        SpawnBullet(spawnPoint[1]);
        SpawnBullet(spawnPoint[3]);
        yield return new WaitForSeconds(2 * spawnInterval);
        SpawnBullet(spawnPoint[0]);
        SpawnBullet(spawnPoint[4]);
    }
    IEnumerator DiamondCoroutine()
    {
        SpawnBullet(spawnPoint[2]);
        yield return new WaitForSeconds(2 * spawnInterval);
        SpawnBullet(spawnPoint[1]);
        SpawnBullet(spawnPoint[3]);
        yield return new WaitForSeconds(2 * spawnInterval);
        SpawnBullet(spawnPoint[0]);
        SpawnBullet(spawnPoint[4]);
        yield return new WaitForSeconds(2 * spawnInterval);
        SpawnBullet(spawnPoint[1]);
        SpawnBullet(spawnPoint[3]);
    }

    IEnumerator SlashCoroutine()
    {
        SpawnBullet(spawnPoint[4]);
        yield return new WaitForSeconds(spawnInterval);
        SpawnBullet(spawnPoint[3]);
        yield return new WaitForSeconds(spawnInterval);
        SpawnBullet(spawnPoint[2]);
        yield return new WaitForSeconds(spawnInterval);
        SpawnBullet(spawnPoint[1]);
    }

    IEnumerator BackslashCoroutine()
    {
        SpawnBullet(spawnPoint[0]);
        yield return new WaitForSeconds(spawnInterval);
        SpawnBullet(spawnPoint[1]);
        yield return new WaitForSeconds(spawnInterval);
        SpawnBullet(spawnPoint[2]);
        yield return new WaitForSeconds(spawnInterval);
        SpawnBullet(spawnPoint[3]);
    }

    IEnumerator TopBottomCoroutine()
    {
        for (int i = 0; i < 3; i++)
        {
            SpawnBullet(spawnPoint[0]);
            SpawnBullet(spawnPoint[2]);
            SpawnBullet(spawnPoint[4]);
            yield return new WaitForSeconds(2 * spawnInterval);
        }
    }

    IEnumerator MiddleCoroutine()
    {
        for (int i = 0; i < 3; i++)
        {
            SpawnBullet(spawnPoint[1]);
            SpawnBullet(spawnPoint[3]);
            yield return new WaitForSeconds(2 * spawnInterval);
        }
    }
    IEnumerator EndingCoroutine()
    {
        for (int i = 0; i < 7; i++)
        {
            SpawnBullet(spawnPoint[0]);
            SpawnBullet(spawnPoint[1]);
            SpawnBullet(spawnPoint[3]);
            SpawnBullet(spawnPoint[4]);
            yield return new WaitForSeconds(spawnInterval);
        }
    }

    public void SpawnBullet(Transform location)
    {
        Vector2 bulletDirection = new Vector2(-bulletSpeed, 0);
        GameObject instantiatedBullet = Instantiate(bullet, location.position, Quaternion.identity);
        instantiatedBullet.gameObject.GetComponent<BidirectionalBullet>().SetBulletDirection(bulletDirection);
        instantiatedBullet.gameObject.GetComponent<BidirectionalBullet>().bulletDamage = bulletDamage;
        instantiatedBullet.gameObject.GetComponent<BidirectionalBullet>().bulletSpeed = bulletSpeed;
    }

    private void OnDrawGizmos()
    {
        foreach (var spots in spawnPoint)
        {
            Gizmos.DrawWireSphere(spots.transform.position, 0.2f);
        }
    }

}
