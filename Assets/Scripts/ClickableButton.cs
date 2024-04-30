using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ClickableButton : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public static ClickableButton hovered;

    public void OnPointerEnter(PointerEventData eventData)
    {
        hovered = this;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        if(hovered) { hovered = null; }
    }

}
