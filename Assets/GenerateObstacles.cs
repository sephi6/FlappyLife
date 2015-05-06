using UnityEngine;
using System.Collections;

public class GenerateObstacles : MonoBehaviour {

    public GameObject obstacle;

	public GameObject obstacle2;

    public Vector2 position = new Vector2(0, 0);

    public float maxRange = 3f;
    public float minRange = -0.8f;


	// Use this for initialization
	void Start () {
		InvokeRepeating ("instanceObstacle", 1f, 1.5f);
			
	}


	
	// Update is called once per frame
    void instanceObstacle()
    {

		if (UIController.instance.entra) {
			position = new Vector2 (10, Random.Range (minRange, maxRange));
			int j = Random.Range(0,2);
			if (j==0){

				Instantiate (obstacle, position, Quaternion.identity);
			}
			else{
				Instantiate (obstacle2, position, Quaternion.identity);
			}
		}
        
    }
}
