﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransfer : MonoBehaviour
{
    public void LoadGame()
    {
        SceneManager.LoadScene("BlackHole");
    }

    public void QuitGame()
    {
        PrefTracker.SaveScores(ScoreTracker.highScores);
        PrefTracker.SaveAudio();
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
