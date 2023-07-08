using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassarFase : MonoBehaviour
{
    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag=="Player")
        {
            if(GameManager.instance.gameStarted)
            {
                this.gameObject.GetComponent<AudioSource>().Play();
                GameManager.instance.PassarDeFase();
            }
        }
    }
}
