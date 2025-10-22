using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaoInfinito : MonoBehaviour
{
    public Transform[] blocos;   // 2 ou mais blocos do chão
    public float velocidade = 5f;

    private float[] larguras;     // largura exata de cada bloco

    void Start()
    {
        // calcula a largura exata de cada sprite
        larguras = new float[blocos.Length];
        for (int i = 0; i < blocos.Length; i++)
        {
            larguras[i] = blocos[i].GetComponent<SpriteRenderer>().bounds.size.x;
        }
    }

    void Update()
    {
        for (int i = 0; i < blocos.Length; i++)
        {
            blocos[i].Translate(Vector2.left * velocidade * Time.deltaTime);

            // se o bloco saiu da tela
            if (blocos[i].position.x <= -larguras[i])
            {
                // reposiciona exatamente à frente do bloco seguinte
                int prox = (i + 1) % blocos.Length;
                float novaPosX = blocos[prox].position.x + larguras[prox];
                blocos[i].position = new Vector3(novaPosX, blocos[i].position.y, blocos[i].position.z);
            }
        }
    }
}
