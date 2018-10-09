﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// EnemigoTonto hereda de EnemigoMovil
public class EnemigoTonto : EnemigoMovil {

    
	
	void Start () {
        InvokeRepeating("RotarAleatoriamente", inicioRotacion, tiempoEntreRotacion);
	}
	
	// Update is called once per frame
	void Update () {
        Avanzar();
    }

    private void OnCollisionEnter(Collision collision) {
        
        RotarAleatoriamente();

        if (collision.gameObject.name == "Personaje")
        {
           
            collision.gameObject.GetComponent<Personaje>().RecibirDanyo(danyo);
            estaVivo = false;
            // Vamos a llamar a la explosion y el sistema de particulas no depende de su generador
            ParticleSystem ps = Instantiate(psExplosion, transform.position, Quaternion.identity);
            ps.Play();
            DestruirEnemigo();
        }
    }

}
