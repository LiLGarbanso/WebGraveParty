using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Dado : MonoBehaviour
{
    public string id, pantallaActual;

    public void CargarPagina()
    {
        if (pantallaActual != id)
        {
            SceneManager.LoadScene(id);
        }
    }
}
