using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CajaVida : MonoBehaviour {

    [SerializeField] int speedRotation = 1;
    int rotacionX = 0;
    int rotacionY = 2;
    int rotacionZ = 0;

    int posMax;
    int posMin;
    int deltaY = 0;
    int rotation = 0;
    bool subiendo = true;

    // Update is called once per frame
    void Update () {
      
        //rotacionX = rotacionX + speedRotation;
        rotacionY = rotacionY + speedRotation;
        //rotacionZ = rotacionZ + speedRotation;

        transform.rotation = Quaternion.Euler(new Vector3(rotacionX, rotacionY, rotacionZ));
        if (subiendo) {
            deltaY++;
            transform.Translate(Vector3.up * Time.deltaTime * -1);
        }
        if(deltaY > 50) {
            subiendo = false;
        } else if (deltaY <= 0) {
            subiendo = true;
        }
	}
}
