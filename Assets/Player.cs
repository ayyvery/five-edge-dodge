using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int speed = 500;

    float movement = 0f;

    // Update is called once per frame
    void Update()
    {
        movement = Input.GetAxisRaw("Horizontal");
    }

    private void FixedUpdate()
    {
        transform.RotateAround(Vector3.zero, Vector3.forward, movement * speed * Time.deltaTime * -1);
    }
}
