using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallWhenCollided : MonoBehaviour
{

    public bool ha = false;
    public bool hi = false;
    
    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag=="Player")
        {
            gameObject.AddComponent<Rigidbody>();
            this.gameObject.GetComponent<Collider>().isTrigger=ha;
            this.gameObject.GetComponent<AudioSource>().Play();
        }
        if(hi)
        {
                gameObject.AddComponent<Rigidbody>();
                this.gameObject.GetComponent<Collider>().isTrigger=ha;
                this.gameObject.GetComponent<AudioSource>().Play();
        }
    }

    void OnCollisionEnter(Collision col)
    {
        if(hi)
        {
                gameObject.AddComponent<Rigidbody>();
                this.gameObject.GetComponent<Collider>().isTrigger=ha;
                this.gameObject.GetComponent<AudioSource>().Play();
        }
    }
}
