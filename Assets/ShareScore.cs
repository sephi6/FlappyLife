using UnityEngine;
using System.Collections;

public class ShareScore : MonoBehaviour {

	public FBHolder2 fbholderscore;

	public void OnMouseDown(){
        int score = UIController.instance.score;

        FB.Feed(

            linkCaption: "Mi record en esta partida es de  " + score,
            picture: "http://i.imgur.com/toojk1W.png",
            linkName: "Game Over",
            //poner un link valido
            link: "https://imgflip.com/s/meme/Ancient-Aliens.jpg/" + FB.AppId + "/?challenge_brag=" + (FB.IsLoggedIn ? FB.UserId : "quest")

            );
		

	}

}
