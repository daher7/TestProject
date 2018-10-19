using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoListo : EnemigoMovil {

	
	
	void Update () {

        Vector3 vDistancia = GetDistancia();

        if(vDistancia.magnitude < 20) {
            this.transform.LookAt(personaje.transform.position);
        }

        Avanzar();
      
    }
}
