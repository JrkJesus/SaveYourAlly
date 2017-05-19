using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Condiciones : MonoBehaviour {

    public int enemiesKilled=0;
    public int enemiesToKill;
    public int chestsTaken=0;
    public int chestsToTake;

    public bool mustKillBoss;
    public bool bossKilled = false;

    public GUIText objectives;

    void OnGUI()
    {
        string texto="";
        if (enemiesToKill != 0)
        {
            texto += "Enemigos: " + enemiesKilled + "/" + enemiesToKill+"\n";
        }
        if (chestsToTake != 0)
        {
            texto += "Cofres: " + chestsTaken + "/" + chestsToTake + "\n";
        }
        if (mustKillBoss)
        {
            texto += "Jefe: " +(bossKilled ? 1 : 0) + "/" + (mustKillBoss ? 1 : 0)+"\n";
        }
        objectives.text=texto;
    }

    // Use this for initialization
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
