using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MidikeyHandler : MonoBehaviour
{
    private InstrumentHandler instrumentHandler;
    private MidiSoundHandler midiSoundHandler;
    private Effectkeys effectKeys;
    private SongPlayer songPlayer;
    private SongPlaybackHandler songPlaybackHandler;

    void Start()
    {
        midiSoundHandler = FindObjectOfType<MidiSoundHandler>();
        instrumentHandler = FindObjectOfType<InstrumentHandler>();
        effectKeys = FindObjectOfType<Effectkeys>();
        songPlayer = FindObjectOfType<SongPlayer>();
        songPlaybackHandler = FindObjectOfType<SongPlaybackHandler>();
    }

    public void MidiKeyUpdate(string midiKey)
    {
        UpDownInstrumentKeys(midiKey);
        EffectKeys(midiKey);
        SongPlayback(midiKey);
    }

    void UpDownInstrumentKeys(string midiKey)
    {

        if (midiKey == "InsUp")
        {
            instrumentHandler.UpInstrumentNumber();
            midiSoundHandler.PlayButtonClick();
        }

        if (midiKey == "InsDown")
        {
            instrumentHandler.DownInstrumentNumber();
            midiSoundHandler.PlayButtonClick();
        }
    }

    void EffectKeys(string midiKey)
    {
        if (midiKey == "Reverb")
        {
            midiSoundHandler.PlayButtonClick();
            effectKeys.Reverb();
        }

        if (midiKey == "Delay")
        {
            midiSoundHandler.PlayButtonClick();
            effectKeys.Delay();
        }

        if (midiKey == "Chorus")
        {
            midiSoundHandler.PlayButtonClick();
            effectKeys.Chorus();
        }
    }

    void SongPlayback(string midiKey)
    {
        if (midiKey == "Play")
        {
            midiSoundHandler.PlayButtonClick();
            songPlayer.SongPlay(songPlaybackHandler.currentSong);
        }

        if (midiKey == "Loop")
        {
            midiSoundHandler.PlayButtonClick();
            songPlayer.Looping();
        }

        if (midiKey == "sngUp")
        {
            midiSoundHandler.PlayButtonClick();
            songPlaybackHandler.SongUp();
        }

        if (midiKey == "sngDown")
        {
            midiSoundHandler.PlayButtonClick();
            songPlaybackHandler.SongDown();
        }
    }
}
