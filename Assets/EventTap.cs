using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class EventTap : MonoBehaviour, IPointerDownHandler, IPointerClickHandler
{
    public int health = 1;
    public void OnPointerDown(PointerEventData eventData)
    {
        Handheld.Vibrate();
        SetRandomColor();
        health --;
        if(health >= 0){
            Destroy(gameObject);
        }
    }

    public void OnPointerClick(PointerEventData eventData)
    {


    }
    
    public void SetRandomColor()
    {
        GetComponent<Renderer>().material.color = Random.ColorHSV();
    }
}
