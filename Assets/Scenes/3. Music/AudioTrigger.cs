using Unity.VisualScripting;
using UnityEngine;

public class AudioTrigger : MonoBehaviour
{
    //1. How to trigger an audio on start & using colliders

    //2. How to implement an ambience system with switchers

    //3. Extra: how to implement audio into the animations


    private AudioSource source;
    private BoxCollider2D collider;


    private void Awake()
    {
        source = GetComponent<AudioSource>();
        collider = GetComponent<BoxCollider2D>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        source.Play();
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        source.Stop();
    }
}
