using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SongPlayer : MonoBehaviour
{
    private keyinput keyInput;
    private bool isPlaying = false;
    private bool isLooping = false;
    public string songName;
    public Light loopLight;
    public Light playLight;
    public void SongPlay(string s)
    {
        songName = s;

        keyInput = FindObjectOfType<keyinput>();

        if (isPlaying)
            return;
        StartCoroutine(PlaySong(songName));
    }

    void Play(string key)
    {
        keyInput.SongInput(key);
    }

    public void Looping()
    {
        isLooping = !isLooping;
        loopLight.enabled = isLooping;
    }

    IEnumerator PlaySong(string songName)
    {
        isPlaying = true;
        playLight.enabled = true;


        //SONGS

        //Fast Travel
        #region 
        if (songName == "Fast Travel")
        {
            Play("e"); Play("g"); Play("b");
            yield return new WaitForSeconds(0.25f);
            Play("e"); Play("g"); Play("b");
            yield return new WaitForSeconds(0.25f);
            Play("e"); Play("g"); Play("b");
            yield return new WaitForSeconds(0.25f);
            Play("d"); Play("f#"); Play("a");
            yield return new WaitForSeconds(0.25f);
            Play("g"); Play("b"); Play("d1");
            yield return new WaitForSeconds(0.25f);
            Play("g"); Play("b"); Play("d1");
            yield return new WaitForSeconds(0.25f);
            Play("g"); Play("b"); Play("d1");
            yield return new WaitForSeconds(0.25f);
            Play("e"); Play("g"); Play("c1");
            yield return new WaitForSeconds(0.125f);
            Play("e"); Play("g"); Play("b");
            yield return new WaitForSeconds(0.125f);
            Play("d"); Play("f#"); Play("a");
            yield return new WaitForSeconds(0.25f);
            Play("d"); Play("f#"); Play("a");
            yield return new WaitForSeconds(0.25f);
            Play("d"); Play("f#"); Play("a");
            yield return new WaitForSeconds(0.25f);
            Play("c"); Play("e"); Play("g");
            yield return new WaitForSeconds(0.125f);
            Play("d"); Play("f#"); Play("a");
            yield return new WaitForSeconds(0.125f);
            Play("e"); Play("g"); Play("b");
            yield return new WaitForSeconds(0.25f);
            Play("g"); Play("b"); Play("d1");
            yield return new WaitForSeconds(0.25f);
            Play("e"); Play("g"); Play("b");
            yield return new WaitForSeconds(0.25f);
            Play("d"); Play("f#"); Play("a");
            yield return new WaitForSeconds(0.25f);
            Play("c"); Play("e"); Play("g");
            yield return new WaitForSeconds(0.25f);
            Play("c"); Play("e"); Play("g");
            yield return new WaitForSeconds(0.25f);
            Play("c"); Play("e"); Play("g");
            yield return new WaitForSeconds(0.25f);
            Play("d"); Play("f#");
            yield return new WaitForSeconds(0.125f);
            Play("c"); Play("e"); Play("g");
            yield return new WaitForSeconds(0.125f);
            Play("d"); Play("f#"); Play("a");
            yield return new WaitForSeconds(0.25f);
            Play("d"); Play("f#"); Play("a");
            yield return new WaitForSeconds(0.25f);
            Play("d"); Play("f#"); Play("a");
            yield return new WaitForSeconds(0.25f);
            Play("c"); Play("e"); Play("g");
            yield return new WaitForSeconds(0.125f);
            Play("d"); Play("f#"); Play("a");
            yield return new WaitForSeconds(0.125f);
            Play("e"); Play("g"); Play("b");
            yield return new WaitForSeconds(0.25f);
            Play("g"); Play("b"); Play("d1");
            yield return new WaitForSeconds(0.25f);
            Play("e"); Play("g"); Play("c1");
            yield return new WaitForSeconds(0.25f);
            Play("e"); Play("g"); Play("b");
            yield return new WaitForSeconds(0.25f);
            Play("d"); Play("f#"); Play("a");
            yield return new WaitForSeconds(0.25f);
            Play("d"); Play("f#"); Play("a");
            yield return new WaitForSeconds(0.25f);
            Play("d"); Play("f#"); Play("a");
            yield return new WaitForSeconds(0.25f);
            Play("d"); Play("f#"); Play("a");
            yield return new WaitForSeconds(0.125f);
            Play("d"); Play("f#"); Play("a");
            yield return new WaitForSeconds(0.125f);
        }
        #endregion

        //megalovenia
        #region
        if (songName == "Megalovania")
        {
            Play("a");
            yield return new WaitForSeconds(0.15f);
            Play("a");
            yield return new WaitForSeconds(0.15f);
            Play("e1");
            yield return new WaitForSeconds(0.3f);
            Play("d#1");
            yield return new WaitForSeconds(0.5f);
            Play("d1");
            yield return new WaitForSeconds(0.3f);
            Play("c1");
            yield return new WaitForSeconds(0.3f);
            Play("a");
            yield return new WaitForSeconds(0.3f);
            Play("a");
            yield return new WaitForSeconds(0.15f);
            Play("c1");
            yield return new WaitForSeconds(0.15f);
            Play("d1");
            yield return new WaitForSeconds(0.15f);

            Play("g");
            yield return new WaitForSeconds(0.15f);
            Play("g");
            yield return new WaitForSeconds(0.15f);
            Play("e1");
            yield return new WaitForSeconds(0.3f);
            Play("d#1");
            yield return new WaitForSeconds(0.5f);
            Play("d1");
            yield return new WaitForSeconds(0.3f);
            Play("c1");
            yield return new WaitForSeconds(0.3f);
            Play("a");
            yield return new WaitForSeconds(0.3f);
            Play("a");
            yield return new WaitForSeconds(0.15f);
            Play("c1");
            yield return new WaitForSeconds(0.15f);
            Play("d1");
            yield return new WaitForSeconds(0.15f);

            Play("f#");
            yield return new WaitForSeconds(0.15f);
            Play("f#");
            yield return new WaitForSeconds(0.15f);
            Play("e1");
            yield return new WaitForSeconds(0.3f);
            Play("d#1");
            yield return new WaitForSeconds(0.5f);
            Play("d1");
            yield return new WaitForSeconds(0.3f);
            Play("c1");
            yield return new WaitForSeconds(0.3f);
            Play("a");
            yield return new WaitForSeconds(0.3f);
            Play("a");
            yield return new WaitForSeconds(0.15f);
            Play("c1");
            yield return new WaitForSeconds(0.15f);
            Play("d1");
            yield return new WaitForSeconds(0.15f);

            Play("a");
            yield return new WaitForSeconds(0.15f);
            Play("a");
            yield return new WaitForSeconds(0.15f);
            Play("e1");
            yield return new WaitForSeconds(0.3f);
            Play("d#1");
            yield return new WaitForSeconds(0.5f);
            Play("d1");
            yield return new WaitForSeconds(0.3f);
            Play("c1");
            yield return new WaitForSeconds(0.3f);
            Play("a");
            yield return new WaitForSeconds(0.3f);
            Play("a");
            yield return new WaitForSeconds(0.15f);
            Play("c1");
            yield return new WaitForSeconds(0.15f);
            Play("d1");
            yield return new WaitForSeconds(0.15f);
        }
        #endregion

        //maramba ringtone
        #region
        if (songName == "Marimba Ringtone")
        {
            Play("e");
            yield return new WaitForSeconds(0.17f);
            Play("c");
            yield return new WaitForSeconds(0.17f);
            Play("g"); Play("c1");
            yield return new WaitForSeconds(0.17f);
            Play("c");
            yield return new WaitForSeconds(0.17f);
            Play("g");
            yield return new WaitForSeconds(0.17f);
            Play("a"); Play("e1");
            yield return new WaitForSeconds(0.17f);
            Play("g"); 
            yield return new WaitForSeconds(0.17f);
            Play("c");
            yield return new WaitForSeconds(0.17f);
            Play("a"); Play("e1");
            yield return new WaitForSeconds(0.17f);
            Play("g");
            yield return new WaitForSeconds(0.17f);
            Play("c");
            yield return new WaitForSeconds(0.17f);
            Play("g"); Play("c1");
            yield return new WaitForSeconds(1.1f);
        }
        #endregion


        if (isLooping)
        {
            StartCoroutine(PlaySong(songName));
        }
        else
        {
            playLight.enabled = false;
            isPlaying = false;
            yield return null;
        }
    }
}
