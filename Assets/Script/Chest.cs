using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour {

    private int _chest = 0;
    [SerializeField]
    public int chest
    {
        get { return _chest; }
        set
        {
            Debug.Log("Pj: " + value);
            _chest = value;
            
        }
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
