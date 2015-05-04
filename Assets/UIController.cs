using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UIController : MonoBehaviour {

    public Text scoreText;

    public int score = 0;

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

}
