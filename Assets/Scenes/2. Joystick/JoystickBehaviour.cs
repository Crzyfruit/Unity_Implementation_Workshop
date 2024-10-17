using UnityEngine;
using UnityEngine.EventSystems;

public class JoystickBehaviour : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    //Implementera s� att man kan trycka p� en knapp och sl�ppa!
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
