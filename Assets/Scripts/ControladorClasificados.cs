using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorClasificados : MonoBehaviour {

    public List<TextMesh> textClasificacionLevel1;
    public List<TextMesh> textClasificacionLevel2;
    public List<TextMesh> textClasificacionLevel3;

    public int numeroClasificados=3;

    // Use this for initialization
    void Start()
    { 
        int i = 0;
        foreach (var text in textClasificacionLevel1)
        {
            text.text = PlayerPrefs.GetString("Clasificacion" + i++);
        }

        foreach (var text in textClasificacionLevel2)
        {
            text.text = PlayerPrefs.GetString("Clasificacion" + i++);
        }

        foreach (var text in textClasificacionLevel3)
        {
            text.text = PlayerPrefs.GetString("Clasificacion" + i++);
        }
    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.X))
        {
            PlayerPrefs.SetString("Clasificacion0", "Antonio: 99999");
            PlayerPrefs.SetString("Clasificacion3", "Jesus: 88888");
            PlayerPrefs.SetString("Clasificacion6", "Juanfran: 77777");

            PlayerPrefs.SetString("Clasificacion1", "Antonio: 5");
            PlayerPrefs.SetString("Clasificacion4", "Jesus: 4");
            PlayerPrefs.SetString("Clasificacion7", "Juanfran: 6");

           

        }
		
	}
}
