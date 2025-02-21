using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class PauseMenu : MonoBehaviour
{
   [SerializeField] GameObject pauseMenu;
    public void Pause()
    {
         gameObject.SetActive(true);
         Time.timeScale = 0;
    }

    public void Resume()
    {
        gameObject.SetActive(false);
        Time.timeScale = 1;
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Main Menu");
        Time.timeScale = 1;
    }

    public void settings()
    {
        SceneManager.LoadScene("Settings");
        Time.timeScale = 0;
    }

    public void Quit()
    {
        Application.Quit();
    }

    // Implement modern networking solution here
    // For example, using NetworkIdentity and NetworkManager
}
