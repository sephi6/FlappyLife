using UnityEngine;
using System.Collections;

public class ShareScore : MonoBehaviour {

	public FBHolder2 fbholderscore;

	public void OnMouseDown(){
		fbholderscore.shareScore ();

	}

}
