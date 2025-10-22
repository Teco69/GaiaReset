using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaoMovimento : MonoBehaviour
{
    public float velocidade = 5f;
    public float distanciaReset = 20f; // até onde o chão vai antes de resetar
    private Vector3 posicaoInicial;

    void Start()
    {
        posicaoInicial = transform.position;
    }

    void Update()
    {
        transform.Translate(Vector2.left * velocidade * Time.deltaTime);

        // quando passar da distância configurada, reseta
        if (Vector2.Distance(posicaoInicial, transform.position) >= distanciaReset)
        {
            transform.position = posicaoInicial;
        }
    }
}


