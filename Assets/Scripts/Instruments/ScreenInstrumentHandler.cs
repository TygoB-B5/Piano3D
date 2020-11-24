using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ScreenInstrumentHandler : MonoBehaviour
{
    private TextMesh screenText;

    void Start()
    {
        screenText = GetComponent<TextMesh>();
    }
    public void UpdateScreen(string instrumentName, int instrumentNumber)
    {
        screenText.text = instrumentNumber.ToString() + "." + instrumentName;
    }
}
