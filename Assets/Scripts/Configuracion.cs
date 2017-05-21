using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Configuracion : MonoBehaviour {

    public Dictionary<string, float> prefs = new Dictionary<string, float>();

	// Use this for initialization
	void Start () {
        prefs["Música"] = PlayerPrefs.GetFloat("Música");
        prefs["Sonido"] = PlayerPrefs.GetFloat("Sonido");

        ChangeAllValues();
	}

    private void ChangeAllValues()
    {
        foreach(var confObject in GameObject.FindGameObjectsWithTag("Configuracion"))
        {
            SliderText txt = confObject.GetComponent<SliderText>();
            txt.value.text = ""+prefs[txt.nombre];
        }
    }

    // Update is called once per frame
    void Update () {
		
	}

    public void Save()
    {
        foreach(var key in prefs.Keys)
        {
            PlayerPrefs.SetFloat(key, prefs[key]);
        }
    }

    public void CancelChanges()
    {
        SceneManager.LoadScene("Main");
    }

    public void SetDefault()
    {
        prefs["Musica"] = 100;
        prefs["Sonido"] = 100;


        ChangeAllValues();
    }
}
