﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

/// <summary>
/// The AudioOptions script accesses the exposed parameters musicVol and sfxVol on the main audio mixer to alter the
/// volume of both. The math inside the functions is to properly convert the linear values from the associated UI sliders
/// into logarithmic values for the attenuation curve of the mixer. It also adjusts the PlayerPref values for the audio as
/// the player changes them, and initializes the audio PlayerPrefs at the beginning of the level.
/// </summary>

public class AudioOptions : MonoBehaviour
{
    public AudioMixer masterMixer;
    public AudioSource musicSource;
    public AudioSource starSpawn;
    public AudioSource blackHole;
    public AudioSource starDestroyer;
    public AudioSource starLoss;

    public void SetMusic(float soundLevel)
    {
        masterMixer.SetFloat("musicVol", Mathf.Log(soundLevel) * 20);
        PlayerPrefs.SetFloat("Music Volume", Mathf.Log(soundLevel) * 20);
    }

    public void SetSfx(float soundLevel)
    {
        masterMixer.SetFloat("sfxVol", Mathf.Log(soundLevel)*20);
        PlayerPrefs.SetFloat("SFX Volume", Mathf.Log(soundLevel) * 20);
    }

    public void MuteMusic()
    {
        musicSource.mute = !musicSource.mute;
    }

    public void MuteSfx()
    {
        starSpawn.mute = !starSpawn.mute;
        blackHole.mute = !blackHole.mute;
        starDestroyer.mute = !starDestroyer.mute;
        starLoss.mute = !starLoss.mute;
    }

    private void Awake()
    {
        masterMixer.SetFloat("musicVol", PlayerPrefs.GetFloat("Music Volume", 0f));
        masterMixer.SetFloat("sfxVol", PlayerPrefs.GetFloat("SFX Volume", 0f));
    }
}
