using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollCamera : MonoBehaviour {

	
	
	// Update is called once per frame
	void Update () {

		if (GameObject.Find("Dino").GetComponent<Dino>().isDead == false)
		{
			transform.Translate(transform.right * 10 * Time.deltaTime);
		}
	}
}
