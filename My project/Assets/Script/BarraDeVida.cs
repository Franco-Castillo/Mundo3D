using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BarraDeVida : MonoBehaviour
{
    public Image barraDeVida;
    public float vidaActual;
    public int vidaMaxima;

    void Start()
    {
        vidaActual = vidaMaxima;
    }

    void Update()
    {
        RevisarVida();

        if ( vidaActual <=0)
        {
            SceneManager.LoadScene("Final");
        }    
    }

    public void RevisarVida()
    {
        barraDeVida.fillAmount = vidaActual / vidaMaxima; 
    }
}
