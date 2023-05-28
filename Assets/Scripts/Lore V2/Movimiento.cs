using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    public Transform usuario;

    private void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            usuario.position -= new Vector3(0.001f,0,0);
        }
        
        if (Input.GetKey(KeyCode.D))
        {
            usuario.position += new Vector3(0.001f,0,0);
        }
        
        if (Input.GetKey(KeyCode.S))
        {
            usuario.position -= new Vector3(0,0.001f,0);
        }
        
        if (Input.GetKey(KeyCode.W))
        {
            usuario.position += new Vector3(0,0.001f,0);
        }
    }
}
