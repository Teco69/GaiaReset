using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class morte : MonoBehaviour
{
    public string nomeCena; // define no inspetor qual cena carregar

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) // só troca se for o player
        {
            SceneManager.LoadScene(nomeCena);
        }
    }
}
