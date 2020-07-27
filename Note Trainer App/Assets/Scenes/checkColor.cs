using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems; // 1
using UnityEngine.UI;


[RequireComponent(typeof(Button))]


public class checkColor : MonoBehaviour
{

    private Color GREY = new Color(0.1960784f, 0.1960784f, 0.1960784f);

    public Text cText;

    private Button button { get { return GetComponent<Button>(); } }

    void Start()
    {

        button.onClick.AddListener(() => checkSelection());

    }

    // Update is called once per frame
    void checkSelection()
    {
        if(cText.color == GREY)
        {
            Debug.Log("tis grey");
        }
        else
        {
            Debug.Log("tis not grey!");
        }
    }
}
