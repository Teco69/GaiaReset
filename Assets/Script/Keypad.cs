using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Keypad : MonoBehaviour
{
    [SerializeField] private Text Ans;
    

    private string Answer = "7191";
    public GameObject sair;
    public GameObject chave;
    

    public void Number(int number)
    {
        Ans.text += number.ToString();
    }

    public void Execute()
    {
        if(Ans.text == Answer)
        {
            Ans.text = "Correct";
            sair.SetActive(true);
            chave.SetActive(true);

        }
        else
        {
            Ans.text = "Invalid";
            StartCoroutine(LimparDepoisDeTempo(2f));
        }
    }
    private IEnumerator LimparDepoisDeTempo(float tempo)
    {
        yield return new WaitForSeconds(tempo);
        Ans.text = ""; // limpa o campo
    }
    
}
