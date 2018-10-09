using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Le decimos a Enemigo Movil que hereda de Enemigo
public class EnemigoMovil : Enemigo {

    [Header("Enemigo Movil")]
    [SerializeField] protected int speed = 1;
    [SerializeField] protected int inicioRotacion = 1;
    [SerializeField] protected int tiempoEntreRotacion = 2;
   

    protected void RotarAleatoriamente() {
        float rotation = Random.Range(0f, 180f);
        transform.eulerAngles = new Vector3(0, rotation, 0);
    }

    protected void Avanzar() {
        if (estaVivo)
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        } 
    }
}
