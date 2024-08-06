using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static bool gameEnded;

    public GameObject gameOverUI;
    public GameObject WinUI;

    public PauseMenu pause;

    void Start()
    {
        gameEnded = false;
    }
    void Update()
    {
        if (gameEnded)
            return;

        if (Input.GetKeyDown(KeyCode.E))
        {
            EndGame();
        }

        if (PlayerStats.Lives <= 0)
        {
            EndGame();
        }
    }

    void EndGame()
    {
        gameEnded = true;
        gameOverUI.SetActive(true);
    }

    public void WinLevel()
    {
        gameEnded = true;
        WinUI.SetActive(true);
    }
}
