using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class ItemTrigger : MonoBehaviour
{
    public Dialogo dialogo;
    public int frase;
    private bool puedeEntrar = true, dentro;

    private void Start()
    {
        dentro = false;
    }

    private void Update()
    {
        if (dentro)
        {
            if (Input.GetKeyDown(KeyCode.X))
            {
                dialogo.CambiarCapa(frase);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        dialogo.puedeHablar = true;
        dentro = true;
        if (!dialogo.mostrando)
        {
            dialogo.fraseActual = frase; 
            dialogo.MostrarFrase();
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        dentro = false;
        dialogo.ReiniciarTexto();
    }
}
