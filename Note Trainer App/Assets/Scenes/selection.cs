using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems; // 1
using UnityEngine.UI;

public class selection : MonoBehaviour, IPointerClickHandler // 2
  
// ... And many more available!
{
    public AudioSource audio;
    private bool selected = false;
    private Color grey;

    void Start()
    {
        grey = new Color(0.1960784f, 0.1960784f, 0.1960784f);
    }

    public void OnPointerClick(PointerEventData eventData) // 3
    {
        

        audio.Play();
        if (selected)
        {
            this.GetComponent<Text>().color = grey;
        }
        else
        {
            this.GetComponent<Text>().color = Color.red;
        }
        selected = !selected;
        
    }
}
