using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems; // 1
using UnityEngine.UI;


[RequireComponent(typeof(Button))]


public class checkColor : MonoBehaviour
{

    private Color GREY = new Color(0.1960784f, 0.1960784f, 0.1960784f);
    private Color darkgreen = new Color(0.09019607f, 0.4056604f, 0.07462621f);

    public Text[] notesText;

    private Button button { get { return GetComponent<Button>(); } }

    public Text results_text;

    public AudioSource success;
    public AudioSource failure;

    void Start()
    {
        

        button.onClick.AddListener(()=> checkSelection());

    }

    // Update is called once per frame
    void checkSelection()
    {
        GameObject generateButton = GameObject.Find("Generate_Button");
        GenerateSound gensound = generateButton.GetComponent<GenerateSound>();
        for (int i = 0; i < notesText.Length; i++)
        
        {
            if (notesText[i].color == Color.red)
            {
                int note = gensound.random_note;

                if (note == i)
                {
                    results_text.text = "CORRECT";
                    results_text.color = darkgreen;
                    success.Play();
                    Debug.Log("Correct");
                    
                }
                else
                {
                    results_text.text = "INCORRECT";
                    results_text.color = Color.red;
                    Debug.Log("Incorrect");
                    failure.Play();
                }
                notesText[i].color = GREY;
                break;


            }
         
        }
        
    }
}
