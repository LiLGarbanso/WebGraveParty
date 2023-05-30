using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class LoreMannager : MonoBehaviour
{
    public GameObject[] capas;
    public Transform usuario, inicio;
    public Dialogo dialogo;
    public string[] frasesIniciales;
    public VideoPlayer vp;
    
    private void Start()
    {
        capas[0].SetActive(true);
        dialogo.MostrarFrase(frasesIniciales[0]);
    }
    
    public void CambiarCapa(int id)
    {
        for (int i = 0; i < capas.Length; i++)
        {
            capas[i].SetActive(false);
        }
        capas[id].SetActive(true);
        usuario.position = inicio.position;
        dialogo.MostrarFrase(frasesIniciales[id]);
    }

    public void Salida()
    {
        SceneManager.LoadScene("MenuPrincipal");
    }

    public void PlayVideo()
    {
        vp.Play();
    }
}
