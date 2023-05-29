using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MediaMng : MonoBehaviour
{
    public Image zoom;
    public GameObject panelZoom;
    public GameObject[] pags;
    public Book libro;
    public int tapaini;
    public int tapafin;

    private void Start()
    {
        foreach (var p in pags)
        {
            p.SetActive(false);
        }
        panelZoom.SetActive(false);
    }

    public void PlayMedia()
    {
        int pag = libro.currentPage;
        if (pag > tapaini && pag < tapafin )
        {
            pags[pag-(tapaini+1)].SetActive(true);
            pags[pag-tapaini].SetActive(true);
        }
    }

    public void CleanMedia()
    {
        foreach (var p in pags)
        {
            p.SetActive(false);
        }
    }

    public void Zoom(Image imagen)
    {
        zoom.sprite = imagen.sprite;
        panelZoom.SetActive(true);
    }

    public void GoLink(string link)
    {
        Application.OpenURL(link);
    }

}
