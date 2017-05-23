using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ArenaControl : MonoBehaviour
{
    public GUIText score;

	void Start()
    {
        Cursor.visible = PlayerPrefs.GetInt("cursorVisibility") == 1;
	}

    void Update()
    {

		if (Input.GetKeyDown(KeyCode.Q))// if reset progress then score =0;
        {
            
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
			PlayerPrefs.SetInt("Score", 0);

        }

       
    }

    void OnGUI()
    {
        score.text = ""+PlayerPrefs.GetInt("Score");
    }
}

