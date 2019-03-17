using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This script manages the audio aspects of the game. It takes references to the SFX Audio source and
/// desired audio clips, then has a function that, when called, will detect if the current narrative node
/// is an end state before playing the corresponding audio clip if it is or is not.
/// </summary>

public class AudioManager : MonoBehaviour
{
    [Header("Audio Sources")]
    public AudioSource sfx;
    public AudioSource music;
    [Header("Audio Clips")]
    public AudioClip baseClip;
    public AudioClip endClip;

    // The function takes one argument to determine if the node is an end state or not.
    public void PlayButtonSfx(bool isEnd)
    {
        if (isEnd)
        {
            sfx.PlayOneShot(endClip);
        }
        else sfx.PlayOneShot(baseClip);
    }

}
