using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    public Transform usuario;
    public Animator animator;

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) ||Input.GetKey(KeyCode.S) ||Input.GetKey(KeyCode.D))
            animator.SetBool("moviendose", true);
        else
            animator.SetBool("moviendose", false);

        if (Input.GetKey(KeyCode.A))
            usuario.position -= new Vector3(0.01f,0,0);
        

        if (Input.GetKey(KeyCode.D))
            usuario.position += new Vector3(0.01f,0,0);
        
        
        if (Input.GetKey(KeyCode.S))
            usuario.position -= new Vector3(0,0.01f,0);
        

        if (Input.GetKey(KeyCode.W))
            usuario.position += new Vector3(0,0.01f,0);
    }
}
