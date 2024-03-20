using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicToggler : MonoBehaviour
{
    public AudioSource Music;
    public static bool audio_mute_trigger = false;

    void Start()
    {
        Music.mute = audio_mute_trigger;
    }

    public void ToggleMusic()
    {
        audio_mute_trigger = !audio_mute_trigger;
        Music.mute = audio_mute_trigger;

    }
}
