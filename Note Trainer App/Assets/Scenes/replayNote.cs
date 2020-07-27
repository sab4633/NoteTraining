using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class replayNote : MonoBehaviour
{
    void OnMouseDown()
    {
        GameObject generateButton = GameObject.Find("Generate_Button");
        GenerateSound gensound = generateButton.GetComponent<GenerateSound>();

        gensound.playSound(gensound.random_note);
    }

}
