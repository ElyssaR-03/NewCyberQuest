using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public void SaveCurrentLevel(int level)
    {
        PlayerPrefs.SetInt("level", level);
        PlayerPrefs.Save();
    }

    // Call this method whenever the player progresses to a new level
    public void OnLevelComplete(int nextLevel)
    {
        SaveCurrentLevel(nextLevel);
        SceneManager.LoadSceneAsync(nextLevel);
    }
}
