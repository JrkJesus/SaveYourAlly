﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour {
    public float timeMax = 60.0f;
    private float countDown;
    public GUIText countDownText;

	// Use this for initialization
	void Start () {
        countDown = timeMax;
	}
	
	// Update is called once per frame
	void Update () {
        countDown -= Time.deltaTime;
        if( countDown <= 0)
        {
            // ToDo: Reset
             // SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
	}

    void OnGUI()
    {
        countDownText.text = "" + Mathf.Round(countDown);
    }
}
