using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GenerateSound : MonoBehaviour
{
    //public int elements;
    public AudioSource[] notes;
    private int random_note;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("starting");
        random_note = 0;
    }

    void OnMouseDown()
    {
        Debug.Log("trying something");
        random_note = (int)Random.Range(0, 8);
        notes[random_note].Play();
    }

    /*
    void PlayRandomNote()
    {
        random_note = (int)Random.Range(0, 8);
        notes[random_note].Play();
    }
    */
}
