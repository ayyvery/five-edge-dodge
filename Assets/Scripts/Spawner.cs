using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float timeBetween = 1f;

    public float nextSpawn = 0f;

    public GameObject hexagon;

    // Update is called once per frame
    void Update()
    {
        if(Time.time >= nextSpawn)
        {
            Instantiate(hexagon);
            nextSpawn = Time.time + timeBetween;
        }
    }
}
