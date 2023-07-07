using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public bool gameStarted = true;
    public int curFase = 1;
    public static GameManager instance;

    public void Start()
    {
        instance = this;
    }

    public void Perdeu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
