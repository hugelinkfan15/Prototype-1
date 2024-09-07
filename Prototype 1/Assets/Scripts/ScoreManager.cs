/*
* Kayden Miller
* CGE 401 Prototype 01
* Script to control the score manager system
*/

using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public static bool gameOver;
    public static bool won;
    public static int score;
    public int winScore;

    public TextMeshProUGUI textbox;

    void Start()
    {
        gameOver = false;
        won = false;
        score = 0;
    }
 
    // Update is called once per frame
    void Update()
    {
        if (!gameOver)
        {
            textbox.text = "Score: " + score;
        }
        if(score>=winScore)
        {
            won = true;
            gameOver = true;
        }

        if(gameOver)
        {
            if(won)
            {
                textbox.text = "You Win!\nPress R to Try Again!";
            }
            else
            {
                textbox.text = "You Lose!\nPress R to Try Again!";
            }
            if ( Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
            
        }
    }
}
