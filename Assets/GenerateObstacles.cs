using UnityEngine;
using System.Collections;

public class GenerateObstacles : MonoBehaviour {

    public GameObject obstacle;

    public Vector2 position = new Vector2(0, 0);

	// Use this for initialization
	void Start () {
        InvokeRepeating("instanceObstacle", 1f, 1.5f);
	}
	
	// Update is called once per frame
    void instanceObstacle()
    {
        Instantiate(obstacle);
    }
}
