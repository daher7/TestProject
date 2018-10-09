using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorEnemigos : MonoBehaviour {

    int numEnemigos = 0;
    [SerializeField] int numEnemigosMaximo = 5;
    [SerializeField] GameObject prefabEnemigo;
    [SerializeField] float ratioNuevoEnemigo = 4;
	
	void Start ()
    {
        // Invocamos a los enemigos nada más comenzar cada 4 segundos(ratioNuevoEnemigo) 
        InvokeRepeating("GenerarEnemigo", 0, ratioNuevoEnemigo);
    }

        
    private void GenerarEnemigo()
    {
        // Vamos a limitar el número de enemigos a 5
        GameObject newEnemigo = Instantiate(prefabEnemigo, transform.position, Quaternion.identity);
        numEnemigos++;
        if(numEnemigos == numEnemigosMaximo)
        {
            CancelInvoke();
        }
    }

}
