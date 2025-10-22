using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickTeleporte : MonoBehaviour
{
    public GameObject player;
    public CamerapersoX cameraScript;

    private OpacidadePlayer opacidade;

    void Start()
    {
        opacidade = player.GetComponent<OpacidadePlayer>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // clique com botão esquerdo
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

                    Debug.Log("Teleportado para nova área");
                }
            }
        }
    }
}

