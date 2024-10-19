using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class HoverboardBehaviour : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    //Implementera s� att man kan aktivera och avaktivera hoverboarden!
    //Sound Designers best friend is: Pitch Randomizer

    public AudioSource source;

    public AudioClip start;
    public AudioClip stop;
    public AudioClip loop;

    private void Awake()
    {
        source = GetComponent<AudioSource>();
        source.clip = loop; //Source
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

        source.PlayOneShot(start);
        source.Play();
    }

    public void PlayerDeactivatedHoverboard()
    {
        Debug.Log("<color=orange> The Player Deactivated The Hoverboard </color>");

        source.Stop();
        source.PlayOneShot(stop);
    }
}
