using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MainMenuController : MonoBehaviour
{    
    public TMP_Dropdown myDrop;
    public GameObject musicaJogo;
    
    void Update()
    {
        PlayerPrefs.SetInt("PlayerQuality", myDrop.value);
    }

    public void OnAtualiazar()
    {
        if (myDrop.value == 0)
        {
            QualitySettings.SetQualityLevel(1, true);
        }
        if (myDrop.value == 1)
        {
            QualitySettings.SetQualityLevel(2, true);
        }
        if (myDrop.value == 2)
        {
            QualitySettings.SetQualityLevel(3, true);
        }
        if (myDrop.value == 3)
        {
            QualitySettings.SetQualityLevel(5, true);
        }    
    }

    public void Start()
    {
        Cursor.lockState=CursorLockMode.None;
        if(!PlayerPrefs.HasKey("PlayerQuality"))
        {
            myDrop.value = 3;
        }
        else{
            myDrop.value = PlayerPrefs.GetInt("PlayerQuality");
        }

        if(!PlayerPrefs.HasKey("PostProcess"))
        {
            PlayerPrefs.SetInt("PostProcess", 1);
        }
    }
    public void PlayThisLevel(string levelName)
    {
        SceneManager.LoadScene(levelName);
        Instantiate(musicaJogo, this.gameObject.transform.position, Quaternion.identity);
    }
    public void QuitGame()
    {
        Application.Quit();
    }

    public void PlayAll()
    {
        SceneManager.LoadScene("Level 1");
        Instantiate(musicaJogo, this.gameObject.transform.position, Quaternion.identity);
    }

}
