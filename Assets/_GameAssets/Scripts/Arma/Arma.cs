using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arma : MonoBehaviour {

    bool activa;

    [SerializeField] int potenciaDisparo = 75;
    [SerializeField] GameObject prefabBala;
    [SerializeField] GameObject puntoGeneracion;

	
    public void ApretarGatillo() {

        GameObject nuevaBala = Instantiate(
            prefabBala,
            puntoGeneracion.transform.position, 
            puntoGeneracion.transform.rotation);

        // Lanzamos la bala
        nuevaBala.GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward * potenciaDisparo);
    }
}
