using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateWithMouse : MonoBehaviour
{
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            this.gameObject.transform.Rotate(Input.mousePosition, Space.Self);
        }
    }
}
