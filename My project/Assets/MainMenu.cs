using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
   public void NewAdventure()
   {
       // Load the first level of the game
       // For example, SceneManager.LoadScene("Level1");

   }

   public void ContinueJourney()
   {
       // Load the last saved level of the game
       // For example, SceneManager.LoadScene("Level2");

   }

   public void Settings()
   {
       // Load the settings menu
       // For example, SceneManager.LoadScene("Settings");
       
   }

   public void Quit()
   {
       // Quit the game
       Application.Quit();
   }

    
}
