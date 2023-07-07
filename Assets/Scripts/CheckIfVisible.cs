using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CheckIfVisible : MonoBehaviour
{

    public LayerMask layerMask;

    public void Update()
    {

    }

    public void OnBecameInvisible()
    {
        if(GameManager.instance.gameStarted)
        {
            GameManager.instance.Perdeu();
        }
    }

}
