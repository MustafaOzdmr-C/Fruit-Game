using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundVolume : MonoBehaviour
{
    private AudioSource audioSour;
    private float musicVolume = 1f;

    private void Start()
    {
        audioSour = GetComponent<AudioSource>();
    }
    private void Update()
    {
        audioSour.volume = musicVolume;
    }

    public void setVolume (float vol)
    {
        musicVolume = vol;
    }
}
