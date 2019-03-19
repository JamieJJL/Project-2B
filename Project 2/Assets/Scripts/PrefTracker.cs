using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public static class PrefTracker
{
    private static float musicMix;
    private static float sfxMix;
    private static List<int> scoreIndexes = new List<int>() { 0,1,2,3,4,5,6,7,8,9 };

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

    public static void SaveAudio()
    {
        AudioOptions.masterMixer.GetFloat("musicVol", out musicMix);
        AudioOptions.masterMixer.GetFloat("sfxVol", out sfxMix);

        PlayerPrefs.SetFloat("Music Volume", musicMix);
        PlayerPrefs.SetFloat("SFX Volume", sfxMix);
    }

    public static void PullAudio()
    {
        AudioOptions.masterMixer.SetFloat("musicVol", PlayerPrefs.GetFloat("Music Volume"));
        AudioOptions.masterMixer.SetFloat("sfxVol", PlayerPrefs.GetFloat("SFX Volume"));
    }
}
