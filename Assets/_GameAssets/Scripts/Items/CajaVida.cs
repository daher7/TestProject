using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CajaVida : MonoBehaviour {

    int rotacion = 0;
    	
	// Update is called once per frame
	void Update () {
        rotacion++;
        transform.rotation = Quaternion.Euler(new Vector3(0, rotacion, 0));
	}
}
