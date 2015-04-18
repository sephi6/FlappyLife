using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class obstacles : MonoBehaviour {

    public Vector2 velocity = new Vector2(4, 0);

    public int score;

    public Text text;

    public float range = 4;

	// Use this for initialization
	void Start () {
        gameObject.rigidbody2D.velocity = velocity;
        gameObject.transform.position = new Vector2(transform.position.x, transform.position.y - range * Random.value);
	}
	
	// Update is called once per frame
	
    void OnTriggerEnter(Collider2D other){
        score += 1;
        text.text = "Score:" + score;
       
    }
}
