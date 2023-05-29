using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoreMannager : MonoBehaviour
{
    public GameObject[] capas;
    public Transform usuario, inicio;
    
    private void Start()
    {
        capas[0].SetActive(true);
    }
    
    public void CambiarCapa(int id)
    {
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
