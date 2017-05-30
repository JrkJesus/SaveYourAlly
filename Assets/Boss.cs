using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour {

    public GameObject robot;
    public int delay;
    private float countDown, sleep;

	// Use this for initialization
	void Start () {
        countDown = delay;
        sleep = 5;
	}
	
	// Update is called once per frame
	void Update () {
        countDown -= Time.deltaTime;

        if(countDown <= 0)
        {
            sleep -= Time.deltaTime;
            if(sleep <= 0)
            {

            }
        }
	}
}
