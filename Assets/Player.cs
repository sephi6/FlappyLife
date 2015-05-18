using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    public Vector2 force = new Vector2(0, 1);

    public bool vivo = true;

    public AudioSource choque;

    public AudioClip choque1;
    public AudioClip choque2;
    public AudioClip choque3;

    public int random;


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

                rigidbody2D.velocity = force;
                gameObject.audio.Play();
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
    IEnumerator espera()
    {
        
        yield return new WaitForSeconds(1.5f);
        if (!FB.IsLoggedIn)
        {
            UIController.instance.share.active=false;
        }
        UIController.instance.menuMuerte.SetActive(true);
    }
    void OnCollisionEnter2D(Collision2D collider)
    {
		if (collider.gameObject.tag == "techo") {
		}else{
            random = Random.Range(0, 3);

            switch (random)
            {
                case 0:
                    Debug.Log("choque:" + random);
                    choque.clip = choque1;
                    break;
                case 1:
                    Debug.Log("choque:" + random);
                    choque.clip = choque2;
                    break;
                case 2:
                    Debug.Log("choque:" + random);
                    choque.clip = choque3;
                    
                    break;
            }

        choque.Play();
		UIController.instance.entra=false;
        //Handheld.Vibrate();
        vivo = false;
		UIController.instance.scoreMenu.text = UIController.instance.score.ToString();

        if (UIController.instance.score >= PlayerPrefs.GetInt("best", 0))
        {
            PlayerPrefs.SetInt("best", UIController.instance.score);

            Debug.Log("Entra score " + UIController.instance.best);
        }
        UIController.instance.best = PlayerPrefs.GetInt("best", 0);
        UIController.instance.bestScore.text = UIController.instance.best.ToString();

        StartCoroutine(espera());

		

        

		}

        

        
    }
    
}
