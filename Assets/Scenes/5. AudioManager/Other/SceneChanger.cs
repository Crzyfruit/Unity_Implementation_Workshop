using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    private static bool switcher = true;
    public void ChangeScene()
    {
        switcher = !switcher; //bool toggler

        if (switcher)
            SceneManager.LoadScene("Music1Scene");
        else
            SceneManager.LoadScene("Music2Scene");
    }
}
