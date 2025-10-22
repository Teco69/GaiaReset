using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cronometro1 : MonoBehaviour
{
   private float timer = 30f;
   public Text cronometroText;
   public string cena;

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime * 1;
        cronometroText.text = Mathf.FloorToInt(timer).ToString();

        if ( timer <= 0f){
            SceneManager.LoadScene(cena);
        }
    }
}
