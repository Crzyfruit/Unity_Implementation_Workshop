using UnityEngine;
using UnityEngine.EventSystems;

public class JoystickBehaviour : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    //Implementera s� att man kan trycka p� en knapp och sl�ppa!
    //What is an array
    //Sound Designers best friend is: Pitch Randomizer :)

    public AudioClip[] Press;
    public AudioClip[] Release;

    public AudioSource source;

    private void Awake()
    {
        source = GetComponent<AudioSource>();
    }

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
        source.PlayOneShot(Press[Random.Range(0, 3)]);
        source.pitch = Random.Range(0.5f, 1.5f);
    }

    public void PlayerReleasedJoystick()
    {
        Debug.Log("<color=orange> The Player Released The Joystick </color>");
        source.PlayOneShot(Release[Random.Range(0, 3)]);
        source.pitch = Random.Range(0.5f, 1.5f);

    }
}
