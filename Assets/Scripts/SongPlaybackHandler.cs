using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SongPlaybackHandler : MonoBehaviour
{
    public string currentSong;
    private int currentSongNumber = 0;
    private string[] allSongs;
    public TextMesh songText;

    void Start()
    {
        allSongs = new string[3];
        allSongs[0] = "Fast Travel";
        allSongs[1] = "Megalovania";
        allSongs[2] = "Marimba Ringtone";

        currentSong = allSongs[0];
        songText.text = allSongs[0];
    }

    public void SongUp()
    {
        if (currentSongNumber < allSongs.Length - 1)
        {
            currentSongNumber += 1;
        }
        UpdateCurrentSong();
    }

    public void SongDown()
    {
        if (currentSongNumber > 0)
        {
            currentSongNumber -= 1;
        }
        UpdateCurrentSong();
    }

    void UpdateCurrentSong()
    {
        currentSong = allSongs[currentSongNumber];
        songText.text = allSongs[currentSongNumber];
    }
}
