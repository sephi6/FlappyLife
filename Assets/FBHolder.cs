using UnityEngine;
using System.Collections;
using Facebook.MiniJSON;
using System.Collections.Generic;

public class FBHolder : MonoBehaviour {


    public static List<string> urls;

    void Start()
    {
        urls = new List<string>();
    }
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
        FB.Login("email,publish_actions", AuthCallback);
       // FB.Login("email", AuthCallback);
    }

    void AuthCallback(FBResult result)
    {
        if (FB.IsLoggedIn)
        {
            Debug.Log("FB login worked!");
            Debug.Log(FB.UserId);
            getPics();
        }
        else
        {
            Debug.Log("FB Login fail");
        }
    }

    public void getPics()
    {
        FB.API("/me/friends?fields=picture", Facebook.HttpMethod.GET, PicsCallback);
    }

    private void PicsCallback(FBResult result)
    {
       Dictionary<string,object> dict= Json.Deserialize(result.Text) as Dictionary <string,object>;
       
       var friends = new List<object>();

       List<object> cosasEnData = dict["data"] as List<object>;

        foreach(object o in cosasEnData)
        {
            Dictionary<string, object> enData = o as Dictionary<string, object>;

            Dictionary<string, object> picture = enData["picture"] as Dictionary<string, object>;

            Dictionary<string, object> datapicture = picture["data"] as Dictionary<string, object>;

            urls.Add(datapicture["url"] as string);
        }
       

       //foreach (object i in dict["data"])
       //{
       //    Dictionary<string, Dictionary<string, object>> aux = i[0] as Dictionary<string, Dictionary<string, object>>;
       //    string url = aux["picture"]["url"] as string;
       //    urls.Add(url);
       //}
       //if (dict.TryGetValue("friends", out friendsH))
       //{
       //    friends = (List<object>)(((Dictionary<string, object>)friendsH)["data"]);
       //    if (friends.Count > 0)
       //    {
       //        Dictionary<string, object> friendPicture = ((Dictionary<string, object>)(friends[2]));

       //        //var friend = new Dictionary<string, string>();
       //        //friend["id"] = (string)friendPicture["id"];
       //        //friend["first_name"] = (string)friendPicture["first_name"];

       //        friends = (List<object>)(((Dictionary<string, object>)friendPicture)["data"]);

       //        if (friends.Count > 0)
       //        {
       //            friendPicture = ((Dictionary<string, object>)(friends[1]));

       //             string url = friendPicture["url"] as string;
       //        }
       //    }
       //}
    }

    
	
	// Update is called once per frame
	
}
