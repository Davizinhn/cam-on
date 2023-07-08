using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CheckIfVisible : MonoBehaviour
{

    public LayerMask layerMask;

    void Update()
    {
        if (!IsObjectVisible(this.transform.gameObject))
        {
            if(GameManager.instance.gameStarted)
            {
                GameManager.instance.Perdeu();
            }
        }
    }

    bool IsObjectVisible(GameObject objeto)
    {
        Renderer renderer = objeto.GetComponent<Renderer>();

        if (renderer != null)
        {
            // Verifique se o objeto é renderizado na câmera principal
            if (renderer.isVisible)
            {
                // Use um raio de colisão para verificar obstruções
                RaycastHit hit;
                Vector3 direction = objeto.transform.position - Camera.main.transform.position;

                if (Physics.Raycast(Camera.main.transform.position, direction, out hit))
                {
                    // Verifique se o objeto atingido pelo raio de colisão não é o objeto-alvo
                    if (hit.collider.gameObject.layer == 3)
                    {
                        // O objeto está obstruído
                        return false;
                    }
                }

                // O objeto não está obstruído
                return true;
            }
            else
            {
                return false;
            }
        }

        // Caso o objeto não tenha um Renderer, assumimos que ele está visível
        return true;
    }








}
