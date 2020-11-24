using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soundhandler : MonoBehaviour
{
    public AudioSource aud;

    public void PlaySound(string keyName, string instrument)
    {
        string soundName = keyName + "_" + instrument;
                aud.PlayOneShot((AudioClip)Resources.Load("sounds/" + soundName, typeof(AudioClip)));
    }
}
