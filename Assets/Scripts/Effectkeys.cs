using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Effectkeys : MonoBehaviour
{
    public bool reverb, delay, chorus;
    public Light reverbLight, delayLight, chorusLight;
    public AudioReverbFilter reverbEffect;
    public AudioEchoFilter delayFilter;
    public AudioChorusFilter chorusFilter;

    public void Reverb()
    {
        reverb = !reverb;
        reverbLight.enabled = reverb;
        reverbEffect.enabled = reverb;
    }

    public void Delay()
    {
        delay = !delay;
        delayLight.enabled = delay;
        delayFilter.enabled = delay;
    }

    public void Chorus()
    {
        chorus = !chorus;
        chorusLight.enabled = chorus;
        chorusFilter.enabled = chorus;
    }
}
