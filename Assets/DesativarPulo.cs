using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesativarPulo : MonoBehaviour
{
    public GameObject puloSound;

    public void ativarPulo()
    {
        Instantiate(puloSound, this.gameObject.transform);
    }
}
