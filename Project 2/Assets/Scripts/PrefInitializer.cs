using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefInitializer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PrefTracker.PullScores(ScoreTracker.highScores);
        PrefTracker.PullAudio();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
