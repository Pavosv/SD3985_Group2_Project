using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthDrop : MonoBehaviour
{
    float wait = 20f; //rate of dropping the health item
    public GameObject fallingObject;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Fall", wait, wait);
    }

    // Update is called once per frame
    void Fall(){
        Instantiate(fallingObject, new Vector3(Random.Range(-20, 10), 10, 0), Quaternion.identity);
    }
}