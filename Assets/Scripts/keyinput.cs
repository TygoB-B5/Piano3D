using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyinput : MonoBehaviour
{
    private Camera cam;
    private Soundhandler sh;
    private InstrumentHandler ins;
    private MidikeyHandler midiKeys;
   

    void Start()
    {
        cam = GetComponent<Camera>();
        sh = FindObjectOfType<Soundhandler>();
        ins = FindObjectOfType<InstrumentHandler>();
        midiKeys = FindObjectOfType<MidikeyHandler>();
    }

    void Update()
    {
        MouseInput();
        KeyInput();
    }

    public void SongInput(string keyName)
    {
        PlayKey(GameObject.Find(keyName).transform);
    }

    void KeyInput()
    {
        if (Input.GetKeyDown(KeyCode.A)) { GameObject g = GameObject.Find("c"); PlayKey(g.transform); }
        if (Input.GetKeyDown(KeyCode.W)) { GameObject g = GameObject.Find("c#"); PlayKey(g.transform); }
        if (Input.GetKeyDown(KeyCode.S)) { GameObject g = GameObject.Find("d"); PlayKey(g.transform); }
        if (Input.GetKeyDown(KeyCode.E)) { GameObject g = GameObject.Find("d#"); PlayKey(g.transform); }
        if (Input.GetKeyDown(KeyCode.D)) { GameObject g = GameObject.Find("e"); PlayKey(g.transform); }
        if (Input.GetKeyDown(KeyCode.F)) { GameObject g = GameObject.Find("f"); PlayKey(g.transform); }
        if (Input.GetKeyDown(KeyCode.T)) { GameObject g = GameObject.Find("f#"); PlayKey(g.transform); }
        if (Input.GetKeyDown(KeyCode.G)) { GameObject g = GameObject.Find("g"); PlayKey(g.transform); }
        if (Input.GetKeyDown(KeyCode.Y)) { GameObject g = GameObject.Find("g#"); PlayKey(g.transform); }
        if (Input.GetKeyDown(KeyCode.H)) { GameObject g = GameObject.Find("a"); PlayKey(g.transform); }
        if (Input.GetKeyDown(KeyCode.U)) { GameObject g = GameObject.Find("a#"); PlayKey(g.transform); }
        if (Input.GetKeyDown(KeyCode.J)) { GameObject g = GameObject.Find("b"); PlayKey(g.transform); }
        if (Input.GetKeyDown(KeyCode.K)) { GameObject g = GameObject.Find("c1"); PlayKey(g.transform); }
        if (Input.GetKeyDown(KeyCode.O)) { GameObject g = GameObject.Find("c#1"); PlayKey(g.transform); }
        if (Input.GetKeyDown(KeyCode.L)) { GameObject g = GameObject.Find("d1"); PlayKey(g.transform); }
        if (Input.GetKeyDown(KeyCode.P)) { GameObject g = GameObject.Find("d#1"); PlayKey(g.transform); }
        if (Input.GetKeyDown(KeyCode.Semicolon)) { GameObject g = GameObject.Find("e1"); PlayKey(g.transform); }
        if (Input.GetKeyDown(KeyCode.Quote)) { GameObject g = GameObject.Find("f1"); PlayKey(g.transform); }
    }

    void MouseInput() //checks mouse input
    {
        if (Input.GetButtonDown("Fire1"))
        {
            RaycastHit hit;
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                PlayKey(hit.transform);
            }
        }
    }

    void PlayKey(Transform key)
    {
        if(key.CompareTag("WhiteKey") || key.CompareTag("BlackKey"))
        {
            sh.PlaySound(key.name, ins.instrumentName);
        }
        else
        {
            midiKeys.MidiKeyUpdate(key.transform.name);
        }

        if (key.CompareTag("WhiteKey"))
        {
            StartCoroutine(PlayWhiteKeyAnimation(key));
        }
        if (key.CompareTag("BlackKey"))
        {
            StartCoroutine(PlayBlackKeyAnimation(key));
        }
    }

    //key animations
    #region
    IEnumerator PlayWhiteKeyAnimation(Transform key)
    {
        key.position = new Vector3(key.position.x, 0.258f, key.position.z);
        yield return new WaitForSeconds(0.02f);
        key.position = new Vector3(key.position.x, 0.2f, key.position.z);
        yield return new WaitForSeconds(0.02f);
        key.position = new Vector3(key.position.x, 0.15f, key.position.z);
        yield return new WaitForSeconds(0.02f);
        key.position = new Vector3(key.position.x, 0.10f, key.position.z);
        yield return new WaitForSeconds(0.02f);
        key.position = new Vector3(key.position.x, 0.02f, key.position.z);
        yield return new WaitForSeconds(0.02f);
        key.position = new Vector3(key.position.x, -0.11f, key.position.z);
        yield return new WaitForSeconds(0.02f);
        key.position = new Vector3(key.position.x, 0.02f, key.position.z);
        yield return new WaitForSeconds(0.02f);
        key.position = new Vector3(key.position.x, 0.10f, key.position.z);
        yield return new WaitForSeconds(0.02f);
        key.position = new Vector3(key.position.x, 0.15f, key.position.z);
        yield return new WaitForSeconds(0.02f);
        key.position = new Vector3(key.position.x, 0.2f, key.position.z);
        yield return new WaitForSeconds(0.02f);
        key.position = new Vector3(key.position.x, 0.258f, key.position.z);
        yield return null;
    }

    IEnumerator PlayBlackKeyAnimation(Transform key)
    {
        key.position = new Vector3(key.position.x, 0.42f, key.position.z);
        yield return new WaitForSeconds(0.02f);
        key.position = new Vector3(key.position.x, 0.35f, key.position.z);
        yield return new WaitForSeconds(0.02f);
        key.position = new Vector3(key.position.x, 0.30f, key.position.z);
        yield return new WaitForSeconds(0.02f);
        key.position = new Vector3(key.position.x, 0.25f, key.position.z);
        yield return new WaitForSeconds(0.02f);
        key.position = new Vector3(key.position.x, 0.20f, key.position.z);
        yield return new WaitForSeconds(0.02f);
        key.position = new Vector3(key.position.x, 0.12f, key.position.z);
        yield return new WaitForSeconds(0.02f);
        key.position = new Vector3(key.position.x, 0.20f, key.position.z);
        yield return new WaitForSeconds(0.02f);
        key.position = new Vector3(key.position.x, 0.25f, key.position.z);
        yield return new WaitForSeconds(0.02f);
        key.position = new Vector3(key.position.x, 0.30f, key.position.z);
        yield return new WaitForSeconds(0.02f);
        key.position = new Vector3(key.position.x, 0.35f, key.position.z);
        yield return new WaitForSeconds(0.02f);
        key.position = new Vector3(key.position.x, 0.42f, key.position.z);
        yield return null;
    }
    #endregion
}
