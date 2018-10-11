using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje : MonoBehaviour {

    private const int NUM_ARMAS = 4;
    private int armaActiva = 3;
    [SerializeField] bool estaVivo;

    [Header("ESTADO")]
    [SerializeField] int vidaActual;
    [SerializeField] int vidaMaxima;

    [Header("ARSENAL")]
    [SerializeField] Arma[] armas = new Arma[NUM_ARMAS];
    [SerializeField] TextMesh tm;
    
    // METODOS GENERALES
    private void Start() {
        ActivarArma(armaActiva);
    }

    private void Update() {
        tm.text = "" + vidaActual;

        // Disparar el arma
        if (Input.GetMouseButtonDown(0)) {
            Disparar();
        }

        // Selección de Armas
        if(Input.GetKeyDown(KeyCode.Alpha1)){
            armaActiva = 0;
            ActivarArma(armaActiva);
        } else if (Input.GetKeyDown(KeyCode.Alpha2)) {
            armaActiva = 1;
            ActivarArma(1);
        } else if (Input.GetKeyDown(KeyCode.Alpha3)) {
            armaActiva = 2;
            ActivarArma(2);
        } else if (Input.GetKeyDown(KeyCode.Alpha4)) {
            armaActiva = 3;
            ActivarArma(3);
        } 
    }

    // METODOS PROPIOS
    public void ActivarArma(int armaActiva) {
        DesactivarArmas();
        armas[armaActiva].gameObject.SetActive(true);
    }

    // Desactivacion del arma
    private void DesactivarArmas() {
        foreach (var arma in armas) {
            arma.gameObject.SetActive(false);
        }
    }

    public void Disparar() {
        armas[armaActiva].ApretarGatillo();
    }

    public void Morir() {
        Debug.Log("Muerto");
        estaVivo = false;
    }

    public void RecibirDanyo(int danyo) {
        vidaActual = vidaActual - danyo;

        if (vidaActual <= 0) {
            vidaActual = 0;
            Morir();
        }
    }

    private void OnMouseDown() {
        Debug.Log("Te estoy tocando");
        RecibirDanyo(10);
    }

    public void IncrementarVida(int incrementoVida) {
        vidaActual += incrementoVida;

        if (vidaActual > vidaMaxima) {
            vidaActual = vidaMaxima;
        }
    }
}
