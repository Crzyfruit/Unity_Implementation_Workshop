using UnityEngine;
using UnityEngine.UI;

public class AudioButtonHandler : MonoBehaviour
{
    private Button button;

    public MusicMode musicMode;
    public enum MusicMode
    {
        PLAY,
        STOP,
        SWITCH
    }

    private void Awake()
    {
        button = GetComponent<Button>();

        button?.onClick.AddListener(() => MusicMethod());
    }

    public void MusicMethod()
    {
        switch (musicMode)
        {
            case MusicMode.PLAY:
                AudioManager.Instance.PlayMusic();
                break;

            case MusicMode.STOP:
                AudioManager.Instance.StopMusic();
                break;

            case MusicMode.SWITCH:
                AudioManager.Instance.SwitchMusic();
                break;
        }
    }
}
