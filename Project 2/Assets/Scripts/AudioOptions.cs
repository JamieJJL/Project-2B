using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioOptions : MonoBehaviour
{
    public AudioMixer masterMixer;

    public void SetMusic(float soundLevel)
    {
        masterMixer.SetFloat("musicVol", Mathf.Log(soundLevel) * 20);
    }

    public void SetSfx(float soundLevel)
    {
        masterMixer.SetFloat("sfxVol", Mathf.Log(soundLevel)*20);
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
