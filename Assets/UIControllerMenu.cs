using UnityEngine;
using System.Collections;

public class UIControllerMenu : MonoBehaviour {

	// Update is called once per frame

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
    public void OnMouseDown () {
		Application.LoadLevel ("juego");
	
	}
}
