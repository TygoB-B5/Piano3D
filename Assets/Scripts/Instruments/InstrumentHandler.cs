using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstrumentHandler : MonoBehaviour
{
    public string instrumentName;
    public int instrumentNumber;
    void Start()
    {
        instrumentNumber = 0;
        UpdateInstrument();
    }

    void UpdateInstrument()
    {
        if (instrumentNumber == 0) instrumentName = "piano";
        if (instrumentNumber == 1) instrumentName = "bright piano";
        if (instrumentNumber == 2) instrumentName = "synth";
        if (instrumentNumber == 3) instrumentName = "bass";
        if (instrumentNumber == 4) instrumentName = "silence";

        UpdateScreenText();
    }

    void UpdateScreenText()
    {
        ScreenInstrumentHandler s;
        s = FindObjectOfType<ScreenInstrumentHandler>();
        s.UpdateScreen(instrumentName, instrumentNumber);
    }

    public void UpInstrumentNumber()
    {
        if (instrumentNumber >= 4)
            return;

        instrumentNumber += 1;
        UpdateInstrument();
    }

    public void DownInstrumentNumber()
    {
        if (instrumentNumber <= 0)
            return;

        instrumentNumber -= 1;
        UpdateInstrument();
    }
}
