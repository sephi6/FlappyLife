﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class obstacles : MonoBehaviour {

    public Vector2 velocity = new Vector2(4, 0);

    public float range = 4;

    

	// Use this for initialization
	void Start () {
        gameObject.rigidbody2D.velocity = velocity;
		Destroy (gameObject, 8f);
        //gameObject.transform.position = new Vector2(transform.position.x, transform.position.y - range * Random.value);
	}
	
	// Update is called once per frame
	
    void OnTriggerEnter2D(Collider2D other){


        gameObject.audio.Play();
        UIController.instance.score += 1;
        UIController.instance.scoreText.text = "" + UIController.instance.score;
        
       
    }
}
