﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

/// <summary>
/// The Player class contains functions that it uses in order to both deduct lives from the Player, as well
/// as increase their score based on their performance. It also contains the code required to start and restart
/// the game on initial startup and upon losing, as well as the references and function required to update the
/// UI elements for displaying current Lives and Score.
/// </summary>
public class Player : MonoBehaviour
{
    public GameObject spawner;
    public AudioSource loss;
    public AudioSource hit;
    public Text lifeCounter;
    public Text scoreCounter;
    public Text startText;
    public static int playerLives;
    public static int playerScore;


    public void LoseLife()
    {
        playerLives -= 1;
        if (playerLives == 0)
        {
            ScoreTracker.CheckScore(playerScore);
            SceneManager.LoadScene("EndScene");
        }
    }
    public void ScoreUp()
    {
        playerScore += 10;
    }
    public void StartGame()
    {
        Time.timeScale = 0;
        playerLives = 10;
        playerScore = 0;
        

        UpdateCounters();
    }
    // Start is called before the first frame update
    void Awake()
    {
        StartGame();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            Time.timeScale = 1;
        }

        if (Time.timeScale == 1)
        {
            startText.gameObject.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            LoseLife();
        }
        UpdateCounters();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        ScoreUp();
        hit.Play();
        Destroy(collision.gameObject);
    }

    private void UpdateCounters()
    {
        lifeCounter.text = $"Lives Remaining:{playerLives}";
        scoreCounter.text = $"Current Score:{playerScore}";
    }

}
