using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems; // 1
using UnityEngine.UI;

public class Deselection : MonoBehaviour
{
    private Color GREY = new Color(0.1960784f, 0.1960784f, 0.1960784f);
    public Text[] notesToDeslect;

    public void deselectAll()
    {
        foreach (Text noteText in notesToDeslect)
        {
            noteText.color = GREY;
        }
    }
}
