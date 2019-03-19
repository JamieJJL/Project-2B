using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// This class uses a function to pause the game and bring up the options menu, which allows the player to change the 
/// volume of the music or sound effects. It is also possible that I may add an additional function to bring up the high
/// score screen in the future.
/// </summary>

public class GameFunctions : MonoBehaviour
{
    public Canvas optionsCanvas;

    private void PauseGame()
    {
            if (Time.timeScale != 0)
            {
                Time.timeScale = 0;
                optionsCanvas.gameObject.SetActive(true);
            }
            else
            {
                Time.timeScale = 1;
                optionsCanvas.gameObject.SetActive(false);
            }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PauseGame();
        }
    }
}
