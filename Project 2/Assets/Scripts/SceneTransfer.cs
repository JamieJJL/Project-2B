using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// This class contains functions to transition between the Start Scene, main Game Scene, and End Scene of the game,
/// as well as save scores, save playerprefs in general, and quit the application.
/// </summary>

public class SceneTransfer : MonoBehaviour
{
    public void LoadGame()
    {
        SceneManager.LoadScene("BlackHole");
    }

    public void QuitGame()
    {
        if (Player.playerScore > 0)
        {
            PrefTracker.SaveScores(ScoreTracker.highScores);
        }
        PlayerPrefs.Save();
        Application.Quit();
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
