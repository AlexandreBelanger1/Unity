using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    //public Player player;
    public void PlayGame()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1f;
        PauseMenuCheck.GameIsPaused = false;
    }

    public void QuitGame()
    {
        Application.Quit();
    }
    public void ReturnToMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void PauseGame()
    {
        SceneManager.LoadScene(2);
    }
    public void LoadGame()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1f;
        PauseMenuCheck.GameIsPaused = false;
      //  player.LoadPlayer();
    }
}
