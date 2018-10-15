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
        // Mirar al personaje
        transform.LookAt(personaje.transform.position);
        // Obtiene el vector distancia
        Vector3 distancia = GetDistancia();
        print("Distancia entre los dos es de : " + distancia.magnitude);
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
