using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoDestruir : MonoBehaviour
{
    [SerializeField] private float tempoParaDestruir = 3f;

     public int dano = 1;
    public float tempoEntreDano = 1f; // tempo de invencibilidade entre hits

    private bool podeDarDano = true;

    void Start()
    {
        Destroy(gameObject, tempoParaDestruir);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && podeDarDano)
        {
            PlayerVida player = other.GetComponent<PlayerVida>();
            if (player != null)
            {
                player.TomarDano(dano);
                StartCoroutine(ResetarDano());
            }
        }
    }

    private IEnumerator ResetarDano()
    {
        podeDarDano = false;
        yield return new WaitForSeconds(tempoEntreDano);
        podeDarDano = true;
    }
}
