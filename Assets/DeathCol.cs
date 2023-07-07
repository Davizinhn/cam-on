using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathCol : MonoBehaviour
{
    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag=="Player")
        {
            if(GameManager.instance.gameStarted)
            {
                GameManager.instance.Perdeu();
            }
        }
    }
}
