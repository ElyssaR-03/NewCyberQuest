using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 
using UnityEngine.UI;

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

    public void Save()
    {
        // Save the game
        int currentLevel = SceneManager.GetActiveScene().buildIndex;
        PlayerPrefs.SetInt("level", currentLevel);
        PlayerPrefs.Save();

        StartCoroutine(ShowSaveMessage());
    }

    private IEnumerator ShowSaveMessage()
    {
        // Show a message that the game is saved
        // For example, using a Text component
        Text saveMessage = pauseMenu.GetComponentInChildren<Text>();
        saveMessage.text = "Game saved!";
        saveMessage.gameObject.SetActive(true);

        yield return new WaitForSeconds(2);

        saveMessage.gameObject.SetActive(false);
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

    public void Exit()
    {
        Application.Quit();
    }

    // Implement modern networking solution here
    // For example, using NetworkIdentity and NetworkManager
}
