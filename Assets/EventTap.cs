using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class EventTap : MonoBehaviour, IPointerDownHandler, IPointerClickHandler
{
    public void OnPointerDown(PointerEventData eventData)
    {
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        SetRandomColor();
    }
    
    public void SetRandomColor()
    {
        GetComponent<Renderer>().material.color = Random.ColorHSV();
    }
}
