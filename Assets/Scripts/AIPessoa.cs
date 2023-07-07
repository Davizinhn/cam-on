using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIPessoa : MonoBehaviour
{
    public Transform akinori;
    public NavMeshAgent agent;

    void Start()
    {
        
    }

    void Update()
    {
        agent.SetDestination(akinori.position);
    }
}
