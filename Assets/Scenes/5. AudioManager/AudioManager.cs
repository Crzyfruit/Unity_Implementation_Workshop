using System.Runtime.CompilerServices;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    // Use a singleton to solve this issue!
    // 
    //--------------------------------------------------------------
    // Make the audio source play only once!
    // Change Music in another scene
    // Remember which music is being played

    private AudioSource audioSource;

    [SerializeField] private AudioClip[] MusicPlaylist;
    private int currentSong;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void PlayMusic()
    {
        Debug.Log("<color=orange>Play Music</color>");
    }

    public void StopMusic()
    {
        Debug.Log("<color=orange>Stop Music</color>");
    }

    public void SwitchMusic()
    {
        Debug.Log("<color=orange>Switch Music</color>");
    }
}
