using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This class was a workaround I came up with for some issues I was having involving showing the high score
/// sheet at the end of the game.
/// </summary>

public class EndingButton : MonoBehaviour
{
    public void ScoreButton()
    {
        GameObject scoreManager = GameObject.Find("ScoreManager");
        scoreManager.GetComponent<ScoreTracker>().ShowScores();
    }

    // Start is called before the first frame update
    void Start()
    {
        ScoreButton();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
