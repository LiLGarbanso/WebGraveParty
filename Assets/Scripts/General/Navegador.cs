using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Navegador : MonoBehaviour
{
    public GameObject dados;
    private bool mostrar;
    public Image dadoPrincipal;

    private void Start()
    {
        mostrar = false;
    }

    public void PulsarDado()
    {
        mostrar = !mostrar;
        dados.SetActive(mostrar);
        
        if (mostrar)
            dadoPrincipal.color = new Color(255,255,255,130);
        else
            dadoPrincipal.color = new Color(255,255,255,255);
    }
}
