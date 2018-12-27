using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObstacles : MonoBehaviour {

	private GameObject obstacle;

	void Start()
	{
		obstacle = GameObject.FindWithTag("obstacle");
	}

	// Update is called once per frame
	void Update () {

		obstacle = GameObject.FindWithTag("obstacle");

		if(transform.position.x > obstacle.transform.position.x + 5)
		{
			Destroy(obstacle);
		}
		
	}
}
