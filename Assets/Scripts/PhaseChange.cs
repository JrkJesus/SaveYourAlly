using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PhaseChange : MonoBehaviour {
    public string phaseToChange = "MenuPrincipal";
    public int phase;
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider collider)
    {
        if(collider.CompareTag("Player") && (PlayerPrefs.GetString("Clasificacion"+((phase-2)*3)) != "" || phase == 1) )
        {
            SceneManager.LoadScene(phaseToChange);
        }
    }
}
