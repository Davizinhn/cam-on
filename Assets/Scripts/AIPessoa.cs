using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIPessoa : MonoBehaviour
{
    public Transform akinori;
    public NavMeshAgent agent;
    public Animator anim;
    public bool isGrounded = true;
    public float distance;
    public float normalSpeed;
    public float jumpSpeed;

    void Start()
    {
        
    }

    void Update()
    {
        RaycastHit hit;
        Ray ray = new Ray(this.gameObject.transform.position, Vector3.down);
        if (Physics.Raycast(ray, out hit, distance)) {
            isGrounded = true;
        }else{isGrounded=false;}
        if(isGrounded)
        {
            agent.speed = normalSpeed;
        }
        else{
            agent.speed = jumpSpeed;
        }
        anim.SetBool("isGrounded", isGrounded);
        anim.SetBool("isRunning", agent.remainingDistance > 0.005f);
        agent.SetDestination(akinori.position);
    }
}
