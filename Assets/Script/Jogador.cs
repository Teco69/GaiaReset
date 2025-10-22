using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jogador : MonoBehaviour
{
    public float forcaPulo = 7f;
    private Rigidbody2D rb;

    [Header("Detecção de chão")]
    public Transform detectorChao; // cria um Empty embaixo do player e arrasta aqui
    public float raio = 0.2f;
    public LayerMask camadaChao;   // define no Inspector qual Layer é o chão

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        bool noChao = Physics2D.OverlapCircle(detectorChao.position, raio, camadaChao);

        if (Input.GetKeyDown(KeyCode.Space) && noChao)
        {
            rb.velocity = new Vector2(rb.velocity.x, forcaPulo);
        }
    }

    void OnDrawGizmosSelected()
    {
        // desenha o sensor na cena pra você ver onde tá
        if (detectorChao != null)
        {
            Gizmos.color = Color.red;
            Gizmos.DrawWireSphere(detectorChao.position, raio);
        }
    }
}
