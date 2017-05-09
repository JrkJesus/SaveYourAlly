using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickChest : MonoBehaviour {
    
    public int nchest = 1;

    // Use this for initialization
    void Start()
    {
        Debug.Log("Cofre soltado");
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
            Chest chest = collider.GetComponent<Chest>();
            Debug.Log("cofre: " + nchest);
            chest.chest += nchest;
            Destroy(gameObject);
        }
    }

}
