using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallWhenCollided : MonoBehaviour
{
    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag=="Player")
        {
            gameObject.AddComponent<Rigidbody>();
            this.gameObject.GetComponent<Collider>().isTrigger=false;
            this.gameObject.GetComponent<AudioSource>().Play();
        }
    }
}
