using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void Start()
    {
        Cursor.lockState=CursorLockMode.None;
    }
    public void PlayThisLevel(string levelName)
    {
        SceneManager.LoadScene(levelName);
    }
    public void QuitGame()
    {
        Application.Quit();
    }

    public void PlayAll()
    {
        SceneManager.LoadScene("Level 1");
    }

}
