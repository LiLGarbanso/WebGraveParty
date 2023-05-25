using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class Cinematica : MonoBehaviour
{
    private float time;
    private bool fin;

    private void Start()
    {
        time = 0;
        fin = false;
    }

    void Update()
    {
        time += Time.deltaTime;

        if (time >= 8f && !fin)
        {
            fin = true;
            SceneManager.LoadScene("Caratula");
        }
    }
}
