using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Salida : MonoBehaviour
{
    public LoreMannager lm;
    public bool salida;
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (salida)
        {
            lm.Salida();
        }
        else
        {
            lm.CambiarCapa(0);
        }
    }
}
