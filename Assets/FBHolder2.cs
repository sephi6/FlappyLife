using UnityEngine;
using System.Collections;

public class FBHolder2 : MonoBehaviour {


	public string scorestring;
	
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

	public void shareScore(){
		int score = UIController.instance.score;


		FB.Feed(
			
			linkCaption: "My en esta partida es de  " + score, 
			linkName: "SCORE"
			//poner un link valido
			//link:"https://imgflip.com/s/meme/Ancient-Aliens.jpg/" + FB.AppId +"/?challenge_brag=" +(FB.IsLoggedIn ? FB.UserId: "quest" )
			
			);
		
		
		
	}
	
	
}






