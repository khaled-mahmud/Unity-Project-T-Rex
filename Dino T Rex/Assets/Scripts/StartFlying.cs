using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartFlying : MonoBehaviour {

	private Animator anim;

	// Use this for initialization
	void Start ()
	{

		anim = GetComponent<Animator>();
		anim.SetTrigger("start");
		
	}
	
	
}
