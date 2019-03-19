using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// This class, though it's a bit messy, is what sorts and prints the high score values on the UI, as well as stores
/// them to be used in playerprefs.
/// </summary>

public class ScoreTracker : MonoBehaviour
{
    public static List<int> highScores = new List<int>() { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
    public Canvas scoreCanvas;
    public Text score1;
    public Text score2;
    public Text score3;
    public Text score4;
    public Text score5;
    public Text score6;
    public Text score7;
    public Text score8;
    public Text score9;
    public Text score10;

    private bool isActive = false;

    public void SetScores()
    {
        score1.text = $"High Score 1: {highScores[0]}";
        score2.text = $"High Score 2: {highScores[1]}";
        score3.text = $"High Score 3: {highScores[2]}";
        score4.text = $"High Score 4: {highScores[3]}";
        score5.text = $"High Score 5: {highScores[4]}";
        score6.text = $"High Score 6: {highScores[5]}";
        score7.text = $"High Score 7: {highScores[6]}";
        score8.text = $"High Score 8: {highScores[7]}";
        score9.text = $"High Score 9: {highScores[8]}";
        score10.text = $"High Score 10: {highScores[9]}";
    }

    public static void CheckScore(int finalScore)
    {
         foreach (int score in highScores)
          {
             if (finalScore >= score)
              {
                 highScores.Insert(highScores.IndexOf(score), finalScore);
                 break;
              }
          }
    }

    public void ShowScores()
    {
        SetScores();
        scoreCanvas.gameObject.SetActive(!isActive);
        isActive = !isActive;
    }

    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }


}
