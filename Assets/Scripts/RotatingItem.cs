using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingItem : MonoBehaviour {

    public float rotaY = 0;
    public float rotaX = 0;
    public float rotaZ = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
       // transform.Rotate(new Vector3(0, 0, Time.deltaTime * 80)); //eje z
        transform.Rotate(new Vector3(Time.deltaTime * rotaX, Time.deltaTime * rotaY, Time.deltaTime * rotaZ)); //eje y
	}
}
