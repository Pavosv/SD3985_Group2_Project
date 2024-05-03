using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed;

    public Transform[] moveSpots;
    private int currentSpot;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame

    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, moveSpots[currentSpot].position, speed * Time.deltaTime);
    }

    public void MoveSpots() //Change the index of the moveSpots[] to move
    {
        if (currentSpot >= moveSpots.Length - 1) //Check the currentSpot
        {
            currentSpot = 0;
        }
        else
        {
            currentSpot += 1;
        }
    }

    private void OnDrawGizmos()
    {
        foreach (var spots in moveSpots)
        {
            Gizmos.DrawWireSphere(spots.transform.position, 0.2f);
        }
    }
}
