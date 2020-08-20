using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class Hexagon : MonoBehaviour
{

    public Rigidbody2D rb;
    public Text scoreField;

    public float speed = 3f;
    public float rotationSpeed = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        rb.rotation = Random.Range(0f, 360f);
        transform.localScale = Vector3.one * 10f;

        scoreField = GameObject.Find("Score").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale -= Vector3.one * speed * Time.deltaTime;
        rb.rotation += rotationSpeed;

        if (transform.localScale.x <= 0.5f)
        {
            Destroy(gameObject);
            scoreField.text = (int.Parse(scoreField.text) + 1).ToString();
        }
    }
}
