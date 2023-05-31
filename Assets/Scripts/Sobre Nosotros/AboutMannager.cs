using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class AboutMannager : MonoBehaviour
{
    public Image[] caretos;
    public GameObject[] stats;

    public void Seleccionar(int id)
    {
        for (int i = 0; i < caretos.Length; i++)
        {
            caretos[i].color = new Color(0.43f,0.43f,0.43f);
            stats[i].SetActive(false);
        }
        
        caretos[id].color = new Color(1,1,1);
        stats[id].SetActive(true);
    }

    public void Atras()
    {
        SceneManager.LoadScene("MenuPrincipal");
    }
}
