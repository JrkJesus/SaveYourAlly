using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlattaform : MonoBehaviour {
    private Transform theTransform = null;
    private Vector3 mov = Vector3.zero;
    private float rangeMov = 0.0f;

    public bool xMovement = false;
    public bool yMovement = false;
    public bool zMovement = false;

    public int range = 0;
    public float maxSpeed = 5.0f;

    void Awake()
    {
        theTransform = GetComponent<Transform>();
        if (xMovement) mov += Vector3.right;
        if (yMovement) mov += Vector3.up;
        if (zMovement) mov += Vector3.forward;

    }

    

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
	}

    void FixedUpdate()
    {
        theTransform.position += mov * maxSpeed;
        rangeMov += mov.sqrMagnitude * maxSpeed;
        if (rangeMov >= range)
        {
            mov -= mov * 2;
            rangeMov = 0.0f;
        }
    }
}
