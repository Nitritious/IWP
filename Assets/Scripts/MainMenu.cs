using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public string levelToLoad = "Map1";

    public void Play()
    {
        SceneManager.LoadScene(levelToLoad);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
