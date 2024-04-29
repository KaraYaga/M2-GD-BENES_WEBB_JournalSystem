using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    // Start
    public void startGame()
    {
        SceneManager.LoadScene("Game");
    }

    // Quit
    public void quitGame()
    {
        Application.Quit();
    }
}
