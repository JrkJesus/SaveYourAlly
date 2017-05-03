using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour {

    private Transform ubicacion = null;
    public GameObject efectoMuerte = null;
    public float damage = 10.0f;

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            Health hp = other.GetComponent<Health>();
            if (hp != null)
            {
                hp.healthPoints -= damage;
                SendMessage("Die", SendMessageOptions.DontRequireReceiver);
                if (efectoMuerte != null)
                {
                    Instantiate(efectoMuerte, ubicacion.position, ubicacion.rotation);
                    Destroy(gameObject);
                }
            }

        }
    }

    //Se ejecuta antes de "Start"
    void Awake()
    {
        ubicacion = GetComponent<Transform>();
    }

    // Use this for initialization
    void Start()
    {

    }

	
	// Update is called once per frame
	void Update () {
		
	}
}
