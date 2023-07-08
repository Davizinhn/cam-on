using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ifNotPlayign : MonoBehaviour
{
    void Update()
    {
        if(!this.gameObject.GetComponent<AudioSource>().isPlaying)
        {
            Destroy(this.gameObject);
        }
    }
}
