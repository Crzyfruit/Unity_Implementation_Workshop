using UnityEngine;
using UnityEngine.EventSystems;

public class JoystickBehaviour : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    //Implementera så att man kan trycka på en knapp och släppa!
    //What is an array
    //Sound Designers best friend is: Pitch Randomizer :)

    public void OnPointerDown(PointerEventData eventData)
    {
        PlayerPressedJoystick();
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        PlayerReleasedJoystick();
    }
    
    public void PlayerPressedJoystick()
    {
        Debug.Log("<color=cyan> The Player Activated The Joystick </color>");
    }

    public void PlayerReleasedJoystick()
    {
        Debug.Log("<color=orange> The Player Released The Joystick </color>");
    }
}
