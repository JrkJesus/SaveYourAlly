using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {

    private Transform ubicacion = null;
    public GameObject efectoMuerte = null;
    public bool shouldExplodeOnDeath = true;


    [SerializeField]
    private float _healthPoints=100.0f;

    public float healthPoints
    {
        get { return _healthPoints; }
        set
        {
            _healthPoints = value;
            if(_healthPoints<=0)
            {
                SendMessage("Die",SendMessageOptions.DontRequireReceiver);
                if(efectoMuerte != null)
                {
                    Instantiate(efectoMuerte,ubicacion.position,ubicacion.rotation);
                    Destroy(gameObject);
                }
            }
        }
    }

    //Se ejecuta antes de "Start"
    void Awake()
    {
        ubicacion = GetComponent<Transform>() ;
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}




}
