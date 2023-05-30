using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialogo : MonoBehaviour
{
    public Text txt;
    [HideInInspector]public bool mostrando, puedeHablar;
    public AudioSource src;
    public AudioClip talk;

    private void Start()
    {
        puedeHablar = true;
        mostrando = false;
    }

    public void MostrarFrase(string s)
    {
        if (!mostrando)
        {
            StartCoroutine(MostrarLetras(s));
        }
    }

    IEnumerator MostrarLetras(string s)
    {
        mostrando = true;
        txt.text = "";
        foreach (char c in s)
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
        txt.text = "";
        mostrando = false;
    }
}
