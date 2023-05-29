using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialogo : MonoBehaviour
{
    public Text txt;
    [HideInInspector]public bool mostrando, puedeHablar;
    public string[] frases;
    public int fraseActual;
    public AudioSource src;
    public AudioClip talk;

    private void Start()
    {
        puedeHablar = true;
        mostrando = false;
        MostrarFrase();
        fraseActual = 0;
    }

    public void MostrarFrase()
    {
        if (!mostrando)
        {
            StartCoroutine(MostrarLetras());
        }
    }

    IEnumerator MostrarLetras()
    {
        mostrando = true;
        txt.text = "";
        foreach (char c in frases[fraseActual])
        {
            if (puedeHablar)
            {
                src.PlayOneShot(talk);
                txt.text += c;
            }
            yield return new WaitForSeconds(0.04f);
        }
        mostrando = false;
    }

    public void ReiniciarTexto()
    {
        StopCoroutine("MostrarLetras");
        puedeHablar = false;
        txt.text = "";
    }
}
