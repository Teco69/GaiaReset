using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortaTeleporte : MonoBehaviour
{
    public Transform destino;

    [Header("Limites da câmera ao teleportar")]
    public float novoLimiteEsquerda = 2f;
    public float novoLimiteDireita = 5f;

    [Header("Mostrar Player ao chegar?")]
    public bool mostraPlayer = true; // Desmarca para esconder
}
