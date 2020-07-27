using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems; // 1
using UnityEngine.UI;


[RequireComponent(typeof(Button))]


public class checkColor : MonoBehaviour
{

    private Color GREY = new Color(0.1960784f, 0.1960784f, 0.1960784f);

    public Text[] notesText;

    private Button button { get { return GetComponent<Button>(); } }

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
                    notesText[i].color = GREY;
                    Debug.Log("Correct");
                    break;
                }
                else
                {
                    Debug.Log("Incorrect");
                }
                

            }
         
        }
        
    }
}
