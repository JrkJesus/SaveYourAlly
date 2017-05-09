using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickHealth : MonoBehaviour {


    public int nhealth = 20;

    // Use this for initialization
    void Start()
    {
        Debug.Log("Caja salud soltada");
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider collider)
    {
        Debug.Log("Entra");
        if (collider.CompareTag("Player"))
        {
            Health health = collider.GetComponent<Health>();
            Debug.Log("Caja: " + nhealth);
            health.healthPoints += nhealth;
            Destroy(gameObject);
        }
    }
}
