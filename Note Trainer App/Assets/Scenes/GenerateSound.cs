using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]

public class GenerateSound : MonoBehaviour
{
    //public int elements;
    public AudioSource[] notes;
    private int random_note;

    private Button button { get { return GetComponent<Button>(); } }

    // Start is called before the first frame update
    void Start()
    {
        gameObject.AddComponent<AudioSource>();
        Debug.Log("starting");
        random_note = 0;

        button.onClick.AddListener(() => playSound());
    }

    void playSound()
    {
        random_note = (int)Random.Range(0, 8);
        notes[random_note].Play();
    }
    /*

    void OnMouseDown()
    {
        Debug.Log("trying something");
        random_note = (int)Random.Range(0, 8);
        notes[random_note].Play();
    }
    */
    /*
    void PlayRandomNote()
    {
        random_note = (int)Random.Range(0, 8);
        notes[random_note].Play();
    }
    */
}
