using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public Text highScoreCounter;
    string highScore;

    // Start is called before the first frame update
    void Start()
    {
        highScore = PlayerPrefs.GetString("highScore", "0");
        highScoreCounter.text = highScore;
    }

    public void onPlayButtonClick()
    {
        SceneManager.LoadScene(1);
    }

}
