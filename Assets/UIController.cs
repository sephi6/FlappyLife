using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UIController : MonoBehaviour {

    public Text scoreText;

    public Text bestScore;
	public Text scoreMenu;

    public Button share;


    public int score = 0;

	public bool entra = false;

	public GameObject menuMuerte;

    public int best;


	// Use this for initialization

    public static UIController instance;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Debug.LogError("Ya había un UI Controller");
        }
    }

	public void OnMouseDown () {
		Application.LoadLevel ("juego");
		
	}





	

}
