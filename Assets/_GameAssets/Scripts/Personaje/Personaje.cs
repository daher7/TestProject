using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje : MonoBehaviour {

    private const int NUM_ARMAS = 4;
    private int armaActiva = 0;
    [SerializeField] bool estaVivo;
    [Header("ESTADO")]
    [SerializeField] int vidaActual;
    [SerializeField] int vidaMaxima;
    [Header("ARSENAL")]
    [SerializeField] GameObject[] armas = new GameObject[NUM_ARMAS];
    [SerializeField] TextMesh tm;
    
    // METODOS GENERALES
    private void Start() {
        ActivarArma(armaActiva);
    }

    private void Update() {
        tm.text = "" + vidaActual;
        if(Input.GetKeyDown(KeyCode.Alpha1)){
            ActivarArma(0);
        } else if (Input.GetKeyDown(KeyCode.Alpha2)) {
            ActivarArma(1);
        } else if (Input.GetKeyDown(KeyCode.Alpha3)) {
            ActivarArma(2);
        } else if (Input.GetKeyDown(KeyCode.Alpha4)) {
            ActivarArma(3);
        } 
    }

    // METODOS PROPIOS
    public void ActivarArma(int armaActiva) {
        DesactivarArmas();
        armas[armaActiva].SetActive(true);
    }

    // Desactivacion del arma
    private void DesactivarArmas() {
        foreach (var arma in armas) {
            arma.SetActive(false);
        }
    }
    public void Atacar() {

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
