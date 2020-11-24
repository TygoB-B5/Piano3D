using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MidiSoundHandler : MonoBehaviour
{
    private AudioSource aud;

    void Start()
    {
        aud = GetComponent<AudioSource>();
    }
    public void PlayButtonClick()
    {
        aud.Play();
    }
}
