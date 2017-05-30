using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Configuracion : MonoBehaviour {

    public Dictionary<string, float> prefs = new Dictionary<string, float>();

    public Slider musica;
    public Slider sonido;
    public Toggle random;
    public Dropdown municion;
    public Dropdown tiempo;
    public Dropdown vida;

    public Button reset;

	// Use this for initialization
	void Start () {
        Cursor.visible = true;
        reset.interactable = PlayerPrefs.GetString("Clasificacion0") != "";
        prefs["Música"] = PlayerPrefs.GetFloat("Música");
        prefs["Sonido"] = PlayerPrefs.GetFloat("Sonido");
        prefs["Random"] = PlayerPrefs.GetFloat("Random");
        prefs["Municion"] = PlayerPrefs.GetFloat("Municion");
        prefs["Vida"] = PlayerPrefs.GetFloat("Vida");
        prefs["Tiempo"] = PlayerPrefs.GetFloat("Tiempo");

        float bonificador = 13;
        bonificador -= prefs["Tiempo"] * 2;
        bonificador -= prefs["Municion"] * 2;
        bonificador -= prefs["Vida"] * 2;
        bonificador += prefs["Random"];

        PlayerPrefs.SetFloat("Bonificador", bonificador);

        ChangeAllValues();
	}

    private void ChangeAllValues()
    {
        musica.GetComponent<Slider>().value = prefs["Música"];
        musica.GetComponent<SliderText>().value.text = ""+prefs["Música"];

        sonido.GetComponent<Slider>().value = prefs["Sonido"];
        sonido.GetComponent<SliderText>().value.text = "" + prefs["Sonido"];

        random.isOn = prefs["Random"] == 1;

        municion.value = (int) prefs["Municion"];

        vida.value = (int) prefs["Vida"];

        tiempo.value = (int) prefs["Tiempo"];

    }

    public void ResetScore()
    {
        PlayerPrefs.DeleteKey("Clasificacion0");
        PlayerPrefs.DeleteKey("Clasificacion1");
        PlayerPrefs.DeleteKey("Clasificacion2");
        PlayerPrefs.DeleteKey("Clasificacion3");
        PlayerPrefs.DeleteKey("Clasificacion4");
        PlayerPrefs.DeleteKey("Clasificacion5");
        PlayerPrefs.DeleteKey("Clasificacion6");
        PlayerPrefs.DeleteKey("Clasificacion7");
        PlayerPrefs.DeleteKey("Clasificacion8");
        reset.interactable = false;
    }

    public void Save()
    {
        foreach (var key in prefs.Keys)
        {
            PlayerPrefs.SetFloat(key, prefs[key]);
        }
        SceneManager.LoadScene("MenuPrincipal");
    }

    public void CancelChanges()
    {
        SceneManager.LoadScene("MenuPrincipal");
    }

    public void changeDropdown(Dropdown active)
    {
        prefs[active.captionText.text.Split(new string[] { " " }, StringSplitOptions.None)[0]] = active.value;
    }

    public void chageRandom(Toggle toggle)
    {
        prefs["Random"] = toggle.isOn ? 1.0f : 0.0f;
    }

    public void SetDefault()
    {
        prefs["Música"] = 100;
        prefs["Sonido"] = 100;
        prefs["Random"] = 0;
        prefs["Tiempo"] = 0;
        prefs["Vida"] = 1;
        prefs["Municion"] = 1;

        ChangeAllValues();
    }

  


}
