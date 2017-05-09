using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickAmmo : MonoBehaviour {

    public int nammo=5;

	// Use this for initialization
	void Start () {
        Debug.Log("Municion soltada");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider collider)
    {
        Debug.Log("Entra");
        if( collider.CompareTag("Player"))
        {
            Shoot shoot = collider.GetComponent<Shoot>();
            Debug.Log("Caja: " + nammo);
            shoot.ammo += nammo;
            Destroy(gameObject);
        }
    }

 
}
