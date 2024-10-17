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
                //Play Music
                break;

            case MusicMode.STOP:
                //Stop Music
                break;

            case MusicMode.SWITCH:
                //Switch Music
                break;
        }
    }
}
