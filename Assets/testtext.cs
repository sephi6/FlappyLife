using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class testtext : MonoBehaviour {

    public static testtext _instance;
    public Text texto;

	// Use this for initialization
	void Start () {
        _instance = this;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public static void UpdateText(string text)
    {
        _instance.texto.text = text;
    }
}
