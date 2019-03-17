using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
    public int playerLives;
    public int playerScore;

    private Vector3 initialPosition;
    private Vector3 spawnerPosition;


    public void LoseLife()
    {
        playerLives -= 1;
        if (playerLives == 0)
        {
            loss.Play();
            ResetGame();
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
    public void ResetGame()
    {
        StartGame();
        SpawnManager sManager = spawner.GetComponent<SpawnManager>();
        sManager.EmptyContainer();
        transform.position = initialPosition;
        spawner.transform.position = spawnerPosition;
    }
    // Start is called before the first frame update
    void Awake()
    {
        initialPosition = transform.position;
        spawnerPosition = spawner.transform.position;
        StartGame();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Time.timeScale = 1;
            startText.gameObject.SetActive(false);
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
