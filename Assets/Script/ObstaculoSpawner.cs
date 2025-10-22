using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaculoSpawner : MonoBehaviour
{
    public GameObject[] obstaculos; 
    public float tempoEntre = 2f;
    public float velocidade = 5f;
    public float dificuldadeRate = 0.1f;
    public float minTempoEntre = 0.8f;

    private float cronometro;
    private ChaoInfinito chao;

    void Start()
    {
        chao = FindObjectOfType<ChaoInfinito>();
    }

    void Update()
    {
        cronometro += Time.deltaTime;

        if (cronometro >= tempoEntre)
        {
            SpawnarObstaculo();
            cronometro = 0f;
        }

        if (tempoEntre > minTempoEntre)
            tempoEntre -= dificuldadeRate * Time.deltaTime;

        velocidade += dificuldadeRate * Time.deltaTime * 0.5f;

        if (chao != null)
            chao.velocidade = velocidade;
    }

    void SpawnarObstaculo()
    {
        int index = Random.Range(0, obstaculos.Length);
        GameObject obj = Instantiate(obstaculos[index], transform.position, Quaternion.identity);

        // Adiciona o script Obstaculo ou pega se já tiver
        Obstaculo comp = obj.GetComponent<Obstaculo>();
        if (comp == null)
            comp = obj.AddComponent<Obstaculo>();

        comp.velocidade = velocidade;
    }
}

