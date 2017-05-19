using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpHeal : MonoBehaviour {

    public int healAmount = 20;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GameObject pj = GameObject.FindWithTag("Player");
            if(pj.GetComponent<Health>().player_health + healAmount>100)
            {
                pj.GetComponent<Health>().player_health = 100;
            }
            else
            {
                pj.GetComponent<Health>().player_health += healAmount;
            }
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
