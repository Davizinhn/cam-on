using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainCanvasController : MonoBehaviour
{
    public static MainCanvasController instance;
    public GameObject cameraCoiso;
    public GameObject victoryPanel;

    public void Start()
    {
        instance=this;
    }

    public void VictoryCoiso()
    {
        cameraCoiso.active=false;
        victoryPanel.active=true;
    }

    public void backToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void NextLevel()
    {
        GameManager.instance.PassarDeFase(true);
    }
}
