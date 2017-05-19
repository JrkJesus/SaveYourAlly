using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpAmmo : MonoBehaviour {

    public int[] municion = new int[] { 6, 10, 20 };
    public int arma   = 0;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            int current = GameObject.FindWithTag("Guns").GetComponent<WeaponManager>().current_Weapon;
            List<GameObject> armas = new List<GameObject> { GameObject.FindWithTag("Pistola"), GameObject.FindWithTag("Francotirador"), GameObject.FindWithTag("Lanzacohetes") };
            ActiveAll(armas);
            armas[arma].GetComponent<Gun>().inventoryAmmo += municion[arma];
            DesactiveAll(armas);
            armas[arma].SetActive(true);
            
        }
    }

    private void DesactiveAll(List<GameObject> armas)
    {
        foreach( var arma in armas)
        {
            arma.SetActive(false);
        }
    }

    private void ActiveAll(List<GameObject> armas)
    {
        foreach (var arma in armas)
        {
            arma.SetActive(true);
        }
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
