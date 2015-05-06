using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    public Vector2 force = new Vector2(0, 1);

    public bool vivo = true;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if (vivo)
        {
            if (Input.GetMouseButtonDown(0))
            {
				rigidbody2D.isKinematic = false;
				UIController.instance.entra = true;
				Debug.Log("entra: " + UIController.instance.entra);
                rigidbody2D.velocity = force;
            }
            foreach (Touch i in Input.touches)
            {
                if (i.phase == TouchPhase.Began)
                {
					
					rigidbody2D.isKinematic = false;
					UIController.instance.entra = true;
                    rigidbody2D.velocity = force;
                }
            }

            rigidbody2D.rotation = rigidbody2D.velocity.y * 6;
        }
        
	}

    void OnCollisionEnter2D(Collision2D collider)
    {
        
        vivo = false;
    }
}
