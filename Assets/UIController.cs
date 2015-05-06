using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UIController : MonoBehaviour {

    public Text scoreText;
	public Text scoreMenu;

    public int score = 0;

	public bool entra = false;

	public GameObject menuMuerte;


	// Use this for initialization

    public static UIController instance;

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
