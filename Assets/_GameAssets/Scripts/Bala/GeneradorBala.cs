using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorBala : MonoBehaviour {

    [SerializeField] GameObject prefabBala;
    [SerializeField] int fuerzaEmpuje = 75;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            
            print("Dispara");
            GameObject nuevaBala = Instantiate(prefabBala, transform.position, transform.rotation);
            nuevaBala.GetComponent<Rigidbody>().AddForce(Vector3.forward * fuerzaEmpuje);
        }
	}

  }
