﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This static class enables the tracking of high scores as playerprefs by iterating across a list of indexes to
/// generate a series of numbered playerpref entries for scores.
/// </summary>

public static class PrefTracker
{
    private static float musicMix;
    private static float sfxMix;
    private static List<int> scoreIndexes = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

    public static void SaveScores(List<int> scoreList)
    {
        foreach (int score in scoreList)
        {
            PlayerPrefs.SetInt($"Score {scoreList.IndexOf(score)}", score);
        }
    }

    public static void PullScores(List<int> scoreList)
    {
        scoreList.Clear();
        foreach (int i in scoreIndexes)
        {
            scoreList.Add(PlayerPrefs.GetInt($"Score {i}"));
        }
    }
}
