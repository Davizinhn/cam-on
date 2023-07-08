using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidroSounds : MonoBehaviour
{
    public AudioClip[] audios;

    public void Awake()
    {
        this.gameObject.GetComponent<AudioSource>().clip = audios[Random.Range(0, audios.Length-1)];
        this.gameObject.GetComponent<AudioSource>().Play();
    }
}
