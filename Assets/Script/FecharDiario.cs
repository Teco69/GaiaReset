using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FecharDiario : MonoBehaviour
{
    public GameObject diario;
    public void OnMouseDown()
    {
        diario.SetActive(false);   
    }
}
