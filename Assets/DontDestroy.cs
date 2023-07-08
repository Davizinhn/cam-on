using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DontDestroy : MonoBehaviour
{
    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    public void Update()
    {
        if(SceneManager.GetActiveScene().name=="MainMenu")
        {
            Destroy(this.gameObject);
        }
    }
}
