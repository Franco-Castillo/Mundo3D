using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Daño : MonoBehaviour
{

    public BarraDeVida barraDeVida;

    public float daño = 2.0f;

    void Start()
    {

    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            barraDeVida.vidaActual -=daño;
        }
    }
}
