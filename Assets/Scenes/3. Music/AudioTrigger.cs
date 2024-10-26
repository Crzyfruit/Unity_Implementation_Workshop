using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class AudioTrigger : MonoBehaviour
{
    //1. How to trigger an audio on start & using colliders

    //2. How to implement an ambience system with switchers

    //3. Extra: how to implement audio into the animations

    [SerializeField] private float fadeDuration = 1.0f;
    private AudioSource source;
    private Coroutine fadeCoroutine;

    [Header("Trigger")]
    [SerializeField] private bool OnEnter; 
    [SerializeField] private bool OnExit; 


    private void Start()
    {
        source = GetComponent<AudioSource>();
        source.volume = 0f;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (OnEnter)
        {
            if (other.CompareTag("Player"))
            {
                if (!source.isPlaying)
                {
                    source.Play();
                    StartCoroutine(FadeAudio(source, 2f, 1f));
                    Debug.Log("Enter!");
                }
            }
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (OnExit)
        {
            if (other.CompareTag("Player"))
            {
                if (source.isPlaying)
                {
                    StartCoroutine(FadeAudio(source, 2f, 1f));
                    source.Stop();
                    Debug.Log("Exit!");
                }
            }
        }
    }

    private IEnumerator FadeAudio(AudioSource source, float duration, float targetVolume)
    {
        float currentTime = 0;
        float start = source.volume;
        while (currentTime < duration)
        {
            currentTime += Time.deltaTime;
            source.volume = Mathf.Lerp(start, targetVolume, currentTime / duration);
            yield return null;
        }
        yield break;
    }
}
