using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems; // 1
using UnityEngine.UI;

public class selection : MonoBehaviour, IPointerClickHandler // 2
  
// ... And many more available!
{
    public AudioSource C4Audio;
    private bool selected = false;


    public void OnPointerClick(PointerEventData eventData) // 3
    {

        C4Audio.Play();
        if (selected)
        {
            this.GetComponent<Text>().color = Color.black;
        }
        else
        {
            this.GetComponent<Text>().color = Color.red;
        }
        selected = !selected;
        
    }
}
