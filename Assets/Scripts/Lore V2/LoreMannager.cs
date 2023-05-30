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
    public GameObject botonInteractuar;

    private void Start()
    {
        capas[0].SetActive(true);
    }
    
    public void CambiarCapa(int id)
    {
        dialogo.cuadroText.SetActive(true);
        for (int i = 0; i < capas.Length; i++)
        {
            capas[i].SetActive(false);
        }
        capas[id].SetActive(true);
        usuario.position = inicio.position;
    }

    public void Salida()
    {
        SceneManager.LoadScene("MenuPrincipal");
    }
}
