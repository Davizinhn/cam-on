using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CheckIfVisible : MonoBehaviour
{

    public LayerMask layerMask;

    public void Update()
    {
        if(!Camera.main.IsObjectVisible(this.gameObject.GetComponent<Renderer>()))
        {
            GameManager.instance.Perdeu();
        }
        else
        {
            RaycastHit hit;
            Ray ray = new Ray(Camera.main.transform.position, this.gameObject.transform.position);                
            Debug.DrawRay(Camera.main.transform.position, this.gameObject.transform.position, Color.green);
            if (Physics.Raycast(ray, out hit, Mathf.Infinity, layerMask)) {
                if(hit.transform.gameObject!=this.gameObject)
                {
                    GameManager.instance.Perdeu();
                }
            }
        }
    }

}
