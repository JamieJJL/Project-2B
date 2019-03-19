using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This class simply initializes the score-pulling function for the PlayerPrefs to provide the high score chart.
/// </summary>

public class PrefInitializer : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        PrefTracker.PullScores(ScoreTracker.highScores);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
