using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class GridSpace : MonoBehaviour {

    public Button button;
    public Text buttonText;
    public string playerSide;

    public void SetSpace()
    {
        Debug.Log("asdasd");
        buttonText.text = playerSide;
        button.interactable = false;
    }

	// Use this for initialization
	void Start () {
        Debug.Log("Hola");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
