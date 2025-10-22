using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cronometro : MonoBehaviour
{
     public float tempoMaximo = 10f; // tempo em segundos
    private float tempoAtual;

    public GameObject objetoParaDesativar; // opcional: objeto a ser afetado

    void Start()
    {
        tempoAtual = tempoMaximo;
    }

    void Update()
    {
        tempoAtual -= Time.deltaTime;

        if (tempoAtual <= 0f)
        {
            AcaoQuandoTempoAcabar();
            enabled = false; // desativa esse script após a ação
        }
    }

    void AcaoQuandoTempoAcabar()
    {
        Debug.Log("O tempo acabou!");

        // Exemplo: desativar um objeto
        if (objetoParaDesativar != null)
        {
            objetoParaDesativar.SetActive(false);
        }

        // Você pode trocar isso por qualquer outra ação:
        // - Trocar de cena
        // - Mostrar UI de "Game Over"
        // - Teleportar o jogador
        // - Resetar o jogo, etc.
    }
}
