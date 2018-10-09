using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorCursi : MonoBehaviour {

    // Declaracion de variables
    int numOvejas = 0;
    [SerializeField] int numOvejasMaximas = 5;
    [SerializeField] GameObject prefabOveja;
    [SerializeField] float ratioNuevaOveja = 0f;

	// Use this for initialization
	void Start () {

        // Invocamos a las ovejas nada más comenzar cada 3 segundos
        InvokeRepeating("GenerarOveja", 0, ratioNuevaOveja);
	}
	
	private void GenerarOveja()
    {
        // Limitamos el numero de ovejas a 10
        GameObject newOveja = Instantiate(prefabOveja, transform);
        numOvejas++;
        if(numOvejas == numOvejasMaximas)
        {
            CancelInvoke();
        }
    }
}
