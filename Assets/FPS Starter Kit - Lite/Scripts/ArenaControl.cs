using UnityEngine;
using System;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ArenaControl : MonoBehaviour
{
    public GUIText score;
    public Text msgFinishGame;
    public int phase;

    public GameObject gui;
    public GameObject finishGUI;
    public GameObject weapons;// weapon manager

    private float timeOut;

	void Start()
    {
        Cursor.visible = PlayerPrefs.GetInt("cursorVisibility") == 1;
	}

    void Update()
    {

		if (Input.GetKeyDown(KeyCode.Q))// if reset progress then score =0;
        {
            changeScene(true);
        }

    }

  
    public void changeScene(bool reset)
    {
        menu_off();
        if(reset) SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        else SceneManager.LoadScene("MenuPrincipal");

        PlayerPrefs.SetInt("Score", 0);
    }

    public void activateFinishGUI(bool win)
    {
        menu_on();

        if (win)
        {
            int score = PlayerPrefs.GetInt("Score");
            string msg = "";
            if (score > getMinScore(phase)) msg += "New record: ";
            msg += score + "\n Introduce tu nombre para guardar la puntuacion: ";
            msgFinishGame.text = msg;
        }
        else
        {
            msgFinishGame.text = "YOU DIED";
            msgFinishGame.color = Color.red;
        }
    }

    void menu_on()// if open menu
    {
        GameObject.FindGameObjectWithTag("Player").GetComponent<MouseLook>().enabled = false;    //
        GameObject.FindGameObjectWithTag("MainCamera").GetComponent<MouseLook>().enabled = false;//
        GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Crosshair>().enabled = false;//   deactivate all fpc scripts
        weapons.SetActive(false);// deactivate weapons
        gui.SetActive(false); // deactivate textures
        finishGUI.SetActive(true);
        Cursor.visible = true; // cursor = true

    }

     void menu_off()// if menu close
    {
        GameObject.FindGameObjectWithTag("Player").GetComponent<MouseLook>().enabled = true;    //
        GameObject.FindGameObjectWithTag("MainCamera").GetComponent<MouseLook>().enabled = true;//
        GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Crosshair>().enabled = true;// activate all fpc scripts
        weapons.SetActive(true);// activate weapons
        gui.SetActive(true);// activate textures
        finishGUI.SetActive(false);
		Cursor.visible = false;// cursor = true

    }

    private int getMinScore(int phase)
    {
        string score = PlayerPrefs.GetString("Clasificacion" + (phase + 2));
        if (score == "")
        {
            return 0;
        }
        else
        {
            return int.Parse(score.Split(new string[] { ": " }, StringSplitOptions.None)[1]);
        }
    }

    void OnGUI()
    {
        score.text = ""+PlayerPrefs.GetInt("Score");
    }
}

