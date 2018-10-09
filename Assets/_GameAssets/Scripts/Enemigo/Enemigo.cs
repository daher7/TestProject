using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour {

    // Declaracion de Variables:

    
    [Header("ESTADO")]
    [SerializeField] protected bool estaVivo = true;
    [SerializeField] int vida = 10;

    [Header("ATAQUE")]
    [SerializeField] int distanciaDeteccion = 5;
    [SerializeField] protected int danyo = 2; // Daño que inflinge el enemigo

    [Header("REFERENCIAS")]
    [SerializeField] protected GameObject personaje;
    
    [Header("FX")]
    [SerializeField] protected ParticleSystem psExplosion; // Creamos en 

    // Declaración de Métodos(funciones):
    public int DetectarDistanciaAlPersonaje() {

        return 0;
    }

    public void Morir() {
        Debug.Log("Muriendo");
        /*
         * 1. Indicar que está muerto.
         * 2. Sistema de particulas.
         * 3. Gritos horribles de dolor/ Despedirse de la vida
         * 4. Destruir el Enemigo.
         * 5. ¿Aumentar salud? ¿Recompensa?
         */
        estaVivo = false;
        // Explosionamos al enemigo
        // Instantiate(explosionEnemigo, transform.position, Quaternion.identity);
        // El enemigo desaparece del juego
        Destroy(this.gameObject);
    }

    public void Atacar() {

    }

    public void RecibirDanyo(int danyo) {
        vida -= danyo;

        if(vida <= 0) {
            vida = 0;
            if (estaVivo) Morir();
        }
    }


    protected void DestruirEnemigo()
    {
        Destroy(this.gameObject);
    }

}
