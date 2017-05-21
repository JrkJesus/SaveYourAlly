using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpAmmo : MonoBehaviour {

    public int municion = 6;
    public int arma   = 0;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            WeaponManager weaponManager = GameObject.FindWithTag("Guns").GetComponent<WeaponManager>();
            weaponManager.recargar(arma, municion);
            Destroy(gameObject);
        }
    }
    
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
