using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coleccionable : MonoBehaviour {
    public static int COUNT = 0;
	// Use this for initialization
	void Start () {
        Coleccionable.COUNT++;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggetEnter(Collider collider)
    {
        if( collider.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }

    void OnDestroy()
    {
        Coleccionable.COUNT--;
        if ( Coleccionable.COUNT <= 0)
        {
            GameObject timer = GameObject.Find("GameTimer");
            Destroy(timer);

            //ToDo: Añadir pantalla de victoria
        }
    }
}
