
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using Unity;
using static Unity.VisualScripting.Member;

public class AudioManager : MonoBehaviour
{
    // Use a singleton to solve this issue!
    // 
    //--------------------------------------------------------------
    // Make the audio source play only once!
    // Change Music in another scene
    // Remember which music is being played

    public AudioSource audioSource;
    [SerializeField] private AudioClip[] MusicPlaylist;
    private int currentSong;

    public static AudioManager Instance;
    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(this);
        }
        audioSource.clip = MusicPlaylist[0];
    }

    public void PlayMusic()
    {
        BetterDebug.Log("Music is Playing", "orange");
        audioSource.Play();
    }

    public void StopMusic()
    {
        audioSource.Stop();
    }

    public void SwitchMusic()
    {
        audioSource.Stop();

        PlayNextClip();
        PlayCurrentClip();
    }

    private void PlayNextClip()
    {
        currentSong = (currentSong + 1) % MusicPlaylist.Length;
        PlayCurrentClip();
    }

    private void PlayCurrentClip()
    {
        audioSource.clip = MusicPlaylist[currentSong];
        audioSource.Play();
    }
}
