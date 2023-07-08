using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Botao : MonoBehaviour
{
    public UnityEngine.UI.Button.ButtonClickedEvent eventToExecute = new UnityEngine.UI.Button.ButtonClickedEvent();
    public Transform proximoAkinori;
    public bool jaclicou=  false;

    public void Update()
    {
        GameObject player = GameObject.Find("Player");
        NavMeshAgent agent = player.GetComponent<NavMeshAgent>();
        if(GameManager.instance.gameStarted && !jaclicou)
        {
            if(agent.remainingDistance<0.01f && agent.gameObject.GetComponent<AIPessoa>().akinori != proximoAkinori)
            {
                jaclicou=true;
                agent.SetDestination(proximoAkinori.position);
                eventToExecute.Invoke();
                this.gameObject.GetComponent<AudioSource>().Play();
            }
        }

    }
}
