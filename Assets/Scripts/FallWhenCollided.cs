using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallWhenCollided : MonoBehaviour
{

    public bool ha = false;
    public bool hi = false;
    bool didFellYet = false;
    
    void OnTriggerEnter(Collider col)
    {
        if(!didFellYet)
        {
            if(col.gameObject.tag=="Player")
            {
                col.gameObject.GetComponent<FirstPersonController>().enableJump = !hi;
                gameObject.AddComponent<Rigidbody>();
                this.gameObject.GetComponent<Collider>().isTrigger=ha;
                this.gameObject.GetComponent<AudioSource>().Play();
                didFellYet = true;
            }
            if(hi)
            {
                    gameObject.AddComponent<Rigidbody>();
                    this.gameObject.GetComponent<Collider>().isTrigger=ha;
                    this.gameObject.GetComponent<AudioSource>().Play();
                    didFellYet = true;
            }
        }

    }
}
