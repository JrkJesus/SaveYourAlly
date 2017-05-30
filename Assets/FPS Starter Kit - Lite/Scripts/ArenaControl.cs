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
    public GameObject tick;
    

    private float timeOut;
    private int points;

	void Start()
    {
        PlayerPrefs.SetInt("MenuFinal", 0);
        menu_off();
    }

    void Update()
    {

		if (Input.GetKeyDown(KeyCode.Q))// if reset progress then score =0;
        {
            //changeScene(true);
            PlayerPrefs.SetInt("Score", PlayerPrefs.GetInt("Score")*2);
        }

    }

  
    public void changeScene(bool reset)
    {
        if(reset) SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        else SceneManager.LoadScene("MenuPrincipal");

        PlayerPrefs.SetInt("Score", 0);
    }

    public void SaveScore()
    {
        bool encontrado = false;
        int i = phase*3;
        string oldScore = "";
        while( !encontrado && i < phase*3+3 )
        {
            string score = PlayerPrefs.GetString("Clasificacion" + i);
            if (score == "" || int.Parse(score.Split(new string[] { ": " }, StringSplitOptions.None)[1]) < points)
            {
                oldScore = PlayerPrefs.GetString("Clasificacion" + i);
                PlayerPrefs.SetString("Clasificacion" + i, GameObject.FindGameObjectWithTag("Puntuacion").GetComponent<InputField>().text + ": " + points);
                GameObject.FindGameObjectWithTag("ButtonSave").GetComponent<Button>().interactable = false;
                tick.SetActive(true);
                encontrado = true;
            }
            else
                i++;
        }

        for(int j = i+1; j < phase*3 + 3; j++)
        {
            string temp = oldScore;
            oldScore = PlayerPrefs.GetString("Clasificacion" + j);
            PlayerPrefs.SetString("Clasificacion" + j, temp);
        }
       
        Debug.Log(i);
    }

    public void activateFinishGUI(bool win)
    {
        PlayerPrefs.SetInt("MenuFinal", 1);
        menu_on();

        if (win)
        {
            points = (int) (PlayerPrefs.GetInt("Score") * (1 + GetComponent<Timer>().timeLeft/100) * PlayerPrefs.GetFloat("Bonificador"));
            string msg = "";
            if (points > getMinScore(phase))
            {
                msg += "New record: ";

              
            }
            else
            {
                msg += "Score: ";
                GameObject.FindGameObjectWithTag("Puntuacion").GetComponent<InputField>().interactable = false;
                GameObject.FindGameObjectWithTag("ButtonSave").GetComponent<Button>().interactable = false;
            }
            msg += points + "\n Introduce tu nombre para guardar la puntuacion: ";
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
        Time.timeScale = 0;
    }

     void menu_off()// if menu close
    {
        GameObject.FindGameObjectWithTag("Player").GetComponent<MouseLook>().enabled = true;    //
        GameObject.FindGameObjectWithTag("MainCamera").GetComponent<MouseLook>().enabled = true;//
        GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Crosshair>().enabled = true;// activate all fpc scripts
        weapons.SetActive(true);// activate weapons
        gui.SetActive(true);// activate textures
        finishGUI.SetActive(false);
        Cursor.visible = PlayerPrefs.GetInt("cursorVisibility") == 1;
        Time.timeScale = 1;
        if (PlayerPrefs.GetInt("MenuFinal") == 1)
        {
            GameObject.FindGameObjectWithTag("Puntuacion").GetComponent<InputField>().interactable = true;
            GameObject.FindGameObjectWithTag("ButtonSave").GetComponent<Button>().interactable = true;
            PlayerPrefs.SetInt("MenuFinal", 0);
        }
    }

    private int getMinScore(int phase)
    {
        string score = PlayerPrefs.GetString("Clasificacion" + (phase*3 + 2));
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

