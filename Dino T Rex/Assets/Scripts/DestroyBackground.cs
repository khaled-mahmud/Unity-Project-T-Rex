using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBackground : MonoBehaviour {

	private float CameraXPos;
	
	// Update is called once per frame
	void Update () {

		CameraXPos = Camera.main.transform.position.x;

		if(CameraXPos > transform.position.x + 20)
		{
			Destroy(gameObject);
		}
		
	}
}
