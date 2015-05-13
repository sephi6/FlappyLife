using UnityEngine;
using System.Collections;

public class Share : MonoBehaviour {

	public FBHolder fbholder;
	// Use this for initialization
	public void OnMouseDown (){
		fbholder.share ();
}
}