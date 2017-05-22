using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpBoxObjetive : MonoBehaviour {

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GameObject condition = GameObject.FindWithTag("GameController");
            condition.GetComponent<Condiciones>().chestsTaken++;
        }
        Destroy(gameObject);
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
