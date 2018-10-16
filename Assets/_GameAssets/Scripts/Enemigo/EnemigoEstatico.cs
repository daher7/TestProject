using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoEstatico : Enemigo {

    [SerializeField] float distanciaAtaque = 5f;
    [SerializeField] GameObject prefabProyectil;
    [SerializeField] Transform posGeneracionProyectil;
    [SerializeField] int potenciaDisparo;
    [SerializeField] float tiempoEntreDisparos = 2f;
    float tiempoAtaque;

    private void Start() {
        tiempoAtaque = tiempoEntreDisparos;
    }

    void Update () {
        // Vector que mide la distancia entre la torreta y el jugador
        // Para que no cabecee, el eje X es la altura de la torreta
        Vector3 target = new Vector3(
            personaje.transform.position.x,
            transform.position.y,
            personaje.transform.position.z
            );

        // Mirar al personaje
        transform.LookAt(target);
        // Obtiene el vector distancia
        Vector3 distancia = GetDistancia();
        //print("Distancia entre los dos es de : " + distancia.magnitude);
        // Evalua si la distancia es menor que la distancia de ataque y ataca
        if (distancia.sqrMagnitude < (distanciaAtaque * distanciaAtaque)) {
            print("ATACA");
            IntentoDeAtaque();
        }
    }

    private void IntentoDeAtaque() {
        print("ATACAR");
        tiempoAtaque += Time.deltaTime;
        if(tiempoAtaque >= tiempoEntreDisparos) {
            tiempoAtaque = 0;
            // Generar disparo y atacar y lanzar
            Disparar();
        }
    }

    private void Disparar() {
        GameObject proyectil = Instantiate
            (prefabProyectil, 
             posGeneracionProyectil.position, 
             posGeneracionProyectil.rotation);
        proyectil.GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward * potenciaDisparo);
    }
}
