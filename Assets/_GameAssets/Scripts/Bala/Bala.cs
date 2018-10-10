﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour {
    
    // Se ejecuta una vez por cada vez que colisione con un objeto
    private void OnTriggerEnter(Collider other) {

        GameObject objetivoImpacto = other.gameObject;
        
        // Saber si es enemigo
        if(objetivoImpacto.tag == "Enemigo") {
            
            objetivoImpacto.GetComponent<Enemigo>().RecibirDanyo(1);
        }

        // Destruccion de la bala
        Destroy(this.gameObject);
    }
}
