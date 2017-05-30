using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
	public float player_health_min = 0;   // min health
    private float _player_health = 100;      // curent health
    public GUIText HP;                     // text which shows the current health
	public float fire_damage = 1;           // fire damage
	public int explosition_damage = 4;     // explosion damage
	public int bullet_damage; // bullet damage
	public int melee_damage=1;// melee atack damage
	public GameObject camera;
    public ArenaControl control;
    private float timeOut;

    [SerializeField]
    public float player_health
    {
        get { return _player_health; }
        set
        {
            _player_health = value;
            if (player_health <= player_health_min)// if curent health <= min health
            {
                _player_health = player_health_min;// curent health = min health
            }
        }
    }
    
    void Start()
    {
        _player_health = (int) (_player_health * 0.5 * (PlayerPrefs.GetFloat("Vida") + 1));
    }
    
    void Update()
    {
        if (player_health <= player_health_min)// if curent health <= min health
        {
            if (!gameObject.GetComponent<Rigidbody>())// if fpc hasn't rigidbody
            {
                //gameObject.GetComponent<Health_BlackTexture>().change_speed = 1;// draw black texture
                camera.GetComponent<Animation>().Play("Die");// the animation play "Die"
                timeOut += Time.deltaTime;// timer active
                if (timeOut >= 1)// after 1 second
                {
                    camera.GetComponent<Animation>().Stop("Die");
                    control.activateFinishGUI(false);
                }
            }
        }
    }
    public void Del()// explosion damage
    {
        player_health -= explosition_damage;// curent health - explosion damage
    }

    void OnTriggerStay(Collider Col)// fire damage
    {
        if (Col.tag == "Fire")// if collider tag = "fire'
        {
            player_health -= fire_damage;// curent health - fire damage
        }
    }

    void OnGUI()// draw curent health
    {
        HP.text = "" + Mathf.Round(player_health);
    }
}

