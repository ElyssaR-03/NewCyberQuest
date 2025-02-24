using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
   public void NewAdventure()
   {
       // Load the first level of the game
       // For example, SceneManager.LoadScene("Level1");
        SceneManager.LoadSceneAsync(1);
        PlayerPrefs.SetInt("level", 1);
   }

   public void ContinueJourney()
   {
       // Load the last saved level of the game
       // For example, SceneManager.LoadScene("Level2");
        int level = PlayerPrefs.GetInt("level", 1); //default to level 1 is not level saved
        SceneManager.LoadSceneAsync(level);
   }

   public void Exit()
   {
       // Quit the game
       Application.Quit();
   }

    
}
