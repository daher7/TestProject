using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour {

    // Destruccion de las balas pasadas 5 segundos
    private void Start() {

        Invoke("Destruir", 5);
    }

    // Se ejecuta una vez por cada vez que colisione con un objeto
    private void OnTriggerEnter(Collider other) {
        print("ONTRIGGERENTER DE LA BALA:" + other.gameObject.name);
        GameObject objetivoImpacto = other.gameObject;

        // Bala Disparada por el personaje
        if(objetivoImpacto.tag == "Enemigo") {
            objetivoImpacto.GetComponent<Enemigo>().RecibirDanyo(1);
        
        // Bala disparada por los enemigos
        } else if (objetivoImpacto.CompareTag("Player")) {
            objetivoImpacto.GetComponent<Personaje>().RecibirDanyo(1);
        }

        // Destruccion de la bala
        Destruir();
    }

    private void Destruir() {
        Destroy(this.gameObject);
    }
}
