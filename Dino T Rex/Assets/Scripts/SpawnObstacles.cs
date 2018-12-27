using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObstacles : MonoBehaviour {

	public GameObject[] obstacles;
	private GameObject obj;
	private float XPos = 0;
	private int number = 0;

	private float randomPosition = 0;

	// Use this for initialization
	void Start ()
	{
		InvokeRepeating("Spawn", 1.5f, 1.6f);
		//Starting in one and a halfseconds, method "Spawn" will be repeated every 1.6 seconds
		
	}

	private void Spawn()
	{
		if(GameObject.Find("Dino").GetComponent<Dino>().isDead == false)
		{
			number = Random.Range(0, 7);
			randomPosition = Random.Range(16, 26);
			//16 is the width of the background; we want to spawn obstacle where the player can't see it
			XPos = transform.position.x + randomPosition;
			obj = obstacles [number] as GameObject;
			//obj is random game object from the array

			Instantiate(obj, new Vector2(XPos, obj.transform.position.y), Quaternion.identity);
		}
	}
	
	
}
