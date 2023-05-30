using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Reproductor : MonoBehaviour
{
    public VideoPlayer vp;

    private void OnEnable()
    {
        vp.Play();
    }

    private void OnDisable()
    {
        vp.Stop();
    }
}
