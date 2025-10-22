using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpacidadePlayer : MonoBehaviour
{
    private SpriteRenderer sr;

    void Awake()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    public void SetVisivel(bool visivel)
    {
        if (sr != null)
        {
            Color c = sr.color;
            c.a = visivel ? 1f : 0f;
            sr.color = c;
        }
    }
}
