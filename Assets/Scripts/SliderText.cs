using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderText : MonoBehaviour {
    public Text nombreText;
    public Text value;
    public Configuracion control;
    public string nombre;
	// Use this for initialization
	void Start () {
        nombreText.text = nombre;
        value.text = "0";
	}

    public void Change(Slider slider)
    {
        value.text = "" + slider.value;
        control.prefs[nombre] = slider.value;
    }

    // Update is called once per frame
    void Update () {
		
	}
}
