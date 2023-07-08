using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public bool gameStarted = false;
    public int curFase = 0;
    public int maxFases = 10;
    public static GameManager instance;


    public void Start()
    {        
        gameStarted=false;
        instance = this;
        int.TryParse(SceneManager.GetActiveScene().name.Split(" ")[1], out curFase);
        Invoke("Comecar", 0.1f);

    }

    public void Comecar()
    {
        gameStarted = true;
    }

    public void Perdeu()
    {
        gameStarted=false;
        SceneManager.LoadScene("DieScreen", LoadSceneMode.Additive);
        Time.timeScale=0.25f;
        GameObject.FindWithTag("Player").GetComponent<FirstPersonController>().mouseSensitivity = 0.04f;
        StartCoroutine(PerderSequence());
    }

    IEnumerator PerderSequence()
    {
        yield return new WaitForSecondsRealtime(1.5f);
        Time.timeScale=1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void PassarDeFase(bool real = false)
    {
        if(!real)
        {
            if(gameStarted)
            {
                gameStarted=false;
                MainCanvasController.instance.VictoryCoiso();
                GameObject.FindWithTag("Player").GetComponent<FirstPersonController>().enabled=false;
                Cursor.lockState = CursorLockMode.None;
            }

        }
        else
        {
                if(curFase+1 <= maxFases)
                {
                    int proxima = curFase+1;
                    SceneManager.LoadScene("Level "+proxima);
                }
                else
                {
                    SceneManager.LoadScene("MainMenu");
                }
        }
    }


    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape) && gameStarted)
        {
            SceneManager.LoadScene("MainMenu");
        }
    }
}
