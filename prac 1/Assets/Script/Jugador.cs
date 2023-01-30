using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{
    public float vidaJugador = 10;
    public Vector3 Direccion;
    public float Velocidad = 1;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        AumentarVida();
        DisminuirVida();
        MoverJugador(ref Direccion);
        VelocidadJugador(ref Direccion);

    }


    void AumentarVida()
    {
        vidaJugador++;
    }

    void DisminuirVida()
    { 
        vidaJugador--;
    }

    void MoverJugador(ref Vector3 dir)
    {
        transform.Translate(dir * Time.deltaTime);
    }

    void VelocidadJugador(ref Vector3 dir)
    {
        transform.Translate (Direccion * Velocidad);
    }
}
