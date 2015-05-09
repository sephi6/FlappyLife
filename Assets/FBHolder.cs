using UnityEngine;
using System.Collections;


public class FBHolder : MonoBehaviour {

	// Use this for initialization
	public void OnMouseDown () {
        FB.Init(SetInit, OnHideUnity);
	}

    private void SetInit()
    {
        Debug.Log("FB Init done.");

        if (FB.IsLoggedIn)
        {
            Debug.Log("Logged in");
        }
        else
        {
            FBlogin();
        }
    }

    private void OnHideUnity(bool isGameShown)
    {
        if (!isGameShown)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }
    }

    void FBlogin()
    {
        FB.Login("user_about_me, user_birthday", AuthCallback);
        //FB.Login("email", AuthCallback);
    }

    void AuthCallback(FBResult result)
    {
        if (FB.IsLoggedIn)
        {
            Debug.Log("FB login worked!");
            Debug.Log(FB.UserId);
        }
        else
        {
            Debug.Log("FB Login fail");
        }
    }

    
	
	// Update is called once per frame
	
}
