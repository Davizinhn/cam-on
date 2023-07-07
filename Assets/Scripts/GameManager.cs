using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public bool gameStarted = true;
    public int curFase = 0;
    public static GameManager instance;

    public void Start()
    {
        instance = this;
        int.TryParse(SceneManager.GetActiveScene().name.Split(" ")[1], out curFase);
    }

    public void Perdeu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void PassarDeFase()
    {
        gameStarted=false;
        if(SceneExists("Fase "+(curFase+1).ToString()))
        {
            SceneManager.LoadScene("Fase "+(curFase+1).ToString());
        }
        else
        {
            SceneManager.LoadScene("MainMenu");
        }
    }

    public bool SceneExists(string Scenename)
    {
        foreach(Scene a in SceneManager.GetAllScenes())
        {
            if(a.name==Scenename)
            {
                return true;
            }
        }
        return false;
    }
}
