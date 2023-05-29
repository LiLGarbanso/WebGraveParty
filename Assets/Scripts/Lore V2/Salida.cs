using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Salida : MonoBehaviour
{
    public LoreMannager lm;
    private void OnTriggerEnter2D(Collider2D col)
    {
        lm.Salida();
    }
}
