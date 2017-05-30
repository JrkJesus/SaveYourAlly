using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour {
    public float timeMax = 60.0f;
    private float countDown;
    public GUIText countDownText;
    public float timeLeft
    {
        get { return countDown; }
    }

	// Use this for initialization
	void Start () {
        countDown = timeMax * (PlayerPrefs.GetFloat("Tiempo") + 1);
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
