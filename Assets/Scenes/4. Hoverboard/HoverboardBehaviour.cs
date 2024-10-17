using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class HoverboardBehaviour : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    //Implementera så att man kan aktivera och avaktivera hoverboarden!
    //Sound Designers best friend is: Pitch Randomizer

    private void Awake()
    {
        
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        PlayerActivatedHoverboard();
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        PlayerDeactivatedHoverboard();
    }
    
    public void PlayerActivatedHoverboard()
    {
        Debug.Log("<color=cyan> The Player Activated The Hoverboard </color>");
    }

    public void PlayerDeactivatedHoverboard()
    {
        Debug.Log("<color=orange> The Player Deactivated The Hoverboard </color>");
    }
}
