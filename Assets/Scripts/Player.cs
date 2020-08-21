using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public int speed = 500;

    float movement = 0f;

    public Text scoreCounter;

    public string finalScore;

    //public AudioClip gameOver;
    //private AudioSource source { get { return GetComponent<AudioSource>(); } }

    private void Start()
    {
        gameObject.AddComponent<AudioSource>();
        //source.clip = gameOver;
        //source.playOnAwake = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A)) { movement = -1; }

        if (Input.GetKeyDown(KeyCode.D)) { movement = 1; }

        if (Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D)) { movement = 0; }
    }

    public void onLeftButtonPress() { movement = -1; }

    public void onRightButtonPress() { movement = 1; }

    public void onMovementButtonRelease() { movement = 0; }

    private void FixedUpdate()
    {
        transform.RotateAround(Vector3.zero, Vector3.forward, movement * speed * Time.deltaTime * -1);
        //Debug.Log("called");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //source.PlayOneShot(gameOver);

        finalScore = scoreCounter.text;

        if (int.Parse(finalScore) > int.Parse(PlayerPrefs.GetString("highScore", "0"))) {

            PlayerPrefs.SetString("highScore", finalScore);

        }

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
