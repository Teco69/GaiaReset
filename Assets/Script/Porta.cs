using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Porta : MonoBehaviour
{
    
    public GameObject player;
    public CamerapersoX cameraScript;



    private OpacidadePlayer opacidade;

    void Start()
    {
        opacidade = player.GetComponent<OpacidadePlayer>();
    }
    private void OnMouseDown()
    {
        if (GameData.temChave)
        {
            
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(mousePos, Vector2.zero);

            if (hit.collider != null && hit.collider.CompareTag("Porta"))
            {
                PortaTeleporte porta = hit.collider.GetComponent<PortaTeleporte>();

                if (porta != null && porta.destino != null)
                {
                    // Teleporta
                    player.transform.position = porta.destino.position;

                    // Define visibilidade do player
                    if (opacidade != null)
                    {
                        opacidade.SetVisivel(porta.mostraPlayer);
                    }

                    // Atualiza limites da câmera
                    if (cameraScript != null)
                    {
                        cameraScript.DefinirLimites(porta.novoLimiteEsquerda, porta.novoLimiteDireita);
                    }

                    
                }
            
        
    }
        }
        else
        {
            Debug.Log("Você precisa de uma chave para abrir.");
        }
    }
    
}
