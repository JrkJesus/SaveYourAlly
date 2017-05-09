using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {

    public int maxAmmo = 50;
    public int _ammo=20;
    public int ammo { 
        get { return _ammo; }
        set
        {
            Debug.Log("Pj: " + value);
            _ammo = value;
            if (_ammo > maxAmmo)
                _ammo = maxAmmo;
        }
    }
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
