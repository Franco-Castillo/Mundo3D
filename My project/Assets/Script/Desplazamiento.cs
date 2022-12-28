using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Desplazamiento : MonoBehaviour //En "PlayerMovimiento" debe ir el nombre del archivo
{

    //Con los 'public float' se crea la variable con la que pueden editar desde la interfaz
    //Al ser "public" se muestra, si fuera "private" no se vería en la interfaz
    public float Speed = 1.0f;
    public float RotationSpeed = 1.0f;
    public float JumpForce = 1.0f;

    private Rigidbody Physics;

    void Start()
    {
        Cursor.visible = false; //Esta linea es para que cuando haga play y haga clic en el juego el cursor se esconde

        Physics = GetComponent<Rigidbody>();
    }

    void Update()
    {
        //Movimiento
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        transform.Translate(new Vector3(horizontal, 0.0f, vertical) * Time.deltaTime * Speed);

        //Rotación
        float rotationY = Input.GetAxis("Mouse X");

        transform.Rotate(new Vector3(0, rotationY * Time.deltaTime * RotationSpeed, 0));

        //Salto
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Physics.AddForce(new Vector3(0, JumpForce, 0), ForceMode.Impulse);
        }

    }
}


