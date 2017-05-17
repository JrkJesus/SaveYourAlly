using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTimer : MonoBehaviour {

    public float timeToDestoy = 2.0f;


	// Use this for initialization
	void Start () {
        Invoke("Die",timeToDestoy);        		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
