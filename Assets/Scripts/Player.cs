using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public int speed = 500;

    float movement = 0f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            movement = -1;
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            movement = 1;
        }

        if (Input.GetKeyUp(KeyCode.A))
        {
            movement = 0;
        }

        if (Input.GetKeyUp(KeyCode.D))
        {
            movement = 0;
        }
    }

    public void onLeftButtonPress()
    {
        movement = -1;
    }

    public void onRightButtonPress()
    {
        movement = 1;
    }

    public void onMovementButtonRelease()
    {
        movement = 0;
    }

    private void FixedUpdate()
    {
        transform.RotateAround(Vector3.zero, Vector3.forward, movement * speed * Time.deltaTime * -1);
        //Debug.Log("called");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
