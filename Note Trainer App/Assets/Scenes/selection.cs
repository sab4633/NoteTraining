using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems; // 1
using UnityEngine.UI;

public class selection : MonoBehaviour, IPointerClickHandler // 2
  
// ... And many more available!
{
    public AudioSource sound;
    private bool selected = false;
    private  Color GREY;

    void Start()
    {
        GREY = new Color(0.1960784f, 0.1960784f, 0.1960784f);
    }

    public void OnPointerClick(PointerEventData eventData) // 3
    {
        if(this.GetComponent<Text>().color == GREY)
        {
            selected = false;
        }
        else
        {
            selected = true;
        }
        GameObject bg = GameObject.Find("background");
        Deselection deselection = bg.GetComponent<Deselection>();

        deselection.deselectAll();

        sound.Play();
        if (selected)
        {
            this.GetComponent<Text>().color = GREY;
        }
        else
        {
            this.GetComponent<Text>().color = Color.red;
        }
        selected = !selected;
        
    }
}
