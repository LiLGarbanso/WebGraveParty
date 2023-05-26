using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Video;

public class Caratula : MonoBehaviour
{
    public Text titulo;
    public string frase;
    private bool pulsado;
    public Animator caratula, start;
    public AudioSource src;
    public AudioClip beep;
    void Start()
    {
        pulsado = false;
        StartCoroutine("Titulo");
    }

    private void Update()
    {
        if (Input.anyKey && !pulsado)
        {
            pulsado = true;
            StartCoroutine("CargarMenu");
        }
    }

    IEnumerator Titulo()
    {
        titulo.text = "";
        foreach (char c in frase.ToCharArray())
        {
            titulo.text += c;
            yield return new WaitForSeconds(0.05f);
        }
    }

    IEnumerator CargarMenu()
    {
        src.PlayOneShot(beep);
        start.SetBool("pulsado",true);
        yield return new WaitForSeconds(1f);
        caratula.SetBool("empezar",true);
        yield return new WaitForSeconds(1.4f);
        SceneManager.LoadScene("Scenes/MenuPrincipal");
    }
}
