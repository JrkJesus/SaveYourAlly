﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingItem : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
       // transform.Rotate(new Vector3(0, 0, Time.deltaTime * 80)); //eje z
        transform.Rotate(new Vector3(0, Time.deltaTime * 80, 0)); //eje y
	}
}
