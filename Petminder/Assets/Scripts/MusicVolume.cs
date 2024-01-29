using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class MusicVolume : MonoBehaviour
{
    public AudioMixer master;

    public void setMusicVolume(float volume) { 
        master.SetFloat("Music Volume", Mathf.Log10(volume)*20); 
    }
}
