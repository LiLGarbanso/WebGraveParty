using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InterfazMannager : MonoBehaviour
{
    private int seccionActual;
    public GameObject[] secciones;
    public Sprite select, disselect;
    public Image[] botones;

    private void Start()
    {
        seccionActual = 0;
        secciones[seccionActual].SetActive(true);
    }

    /*
     * Para los botones
     */
    public void CambiarSeccion(int id)
    {
        if (id != seccionActual)
        {
            seccionActual = id;
            Deseleccionar();
            secciones[seccionActual].SetActive(true);
            botones[seccionActual].sprite = select;
        }
    }

    /*
     * Flecha derecha
     */
    public void Next()
    {
        if (seccionActual == secciones.Length-1)
            seccionActual = 0;
        else
            seccionActual++;
        
        Deseleccionar();
        secciones[seccionActual].SetActive(true);
        botones[seccionActual].sprite = select;
    }

    /*
     * Flecha izquierda
     */
    public void Back()
    {
        if (seccionActual == 0)
            seccionActual = secciones.Length-1;
        else
            seccionActual--;
        
        Deseleccionar();
        secciones[seccionActual].SetActive(true);
        botones[seccionActual].sprite = select;
    }

    public void Deseleccionar()
    {
        for (int i = 0; i < secciones.Length; i++)
        {
            secciones[i].SetActive(false);
            botones[i].sprite = disselect;
        }
    }
}
