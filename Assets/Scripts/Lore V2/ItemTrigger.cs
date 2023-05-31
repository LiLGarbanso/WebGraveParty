using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.Video;

public class ItemTrigger : MonoBehaviour
{
    public Dialogo dialogo;
    public LoreMannager lm;
    public int capa;
    public string frase;
    private bool  dentro;
    public bool tp;

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
                dialogo.ReiniciarTexto();
                if (tp)
                    lm.CambiarCapa(capa);
                dialogo.puedeHablar = true;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (tp)
            lm.botonInteractuar.SetActive(true);
        dialogo.cuadroText.SetActive(true);
        dialogo.puedeHablar = true;
        dentro = true;
        if (!dialogo.mostrando)
        {
            dialogo.MostrarFrase(frase);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        lm.botonInteractuar.SetActive(false);
        dentro = false;
        dialogo.ReiniciarTexto();
        dialogo.cuadroText.SetActive(false);
    }
}
