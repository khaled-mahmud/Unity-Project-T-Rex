using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Dino : MonoBehaviour {

	private Rigidbody2D rb;
	private bool isGrounded = true;

	private Animator anim;
	public bool isDead = false;

	private float score = 0;
	public Text scoreText;
	public GameObject gameOverText;

	private int currentScene;

	AudioSource source;
	public AudioClip jump;
	public AudioClip dead;
	public AudioClip scoreSound;

	// Use this for initialization
	void Start () {

		rb = GetComponent<Rigidbody2D>();
		anim = GetComponent<Animator>();

		currentScene = SceneManager.GetActiveScene().buildIndex;

		source = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (isDead == false)
		{
			CheckScore();

			DinoRun();

			if (Input.GetMouseButtonDown(0) && isGrounded == true)
			{
				DinoJump();
			}
		}

		if(isDead == true && Input.GetMouseButtonDown(0))
		{
			SceneManager.LoadScene(currentScene);
		}


	}

	private void DinoRun()
	{
		transform.Translate(transform.right * 10 * Time.deltaTime);
	}

	private void DinoJump()
	{
		rb.velocity = new Vector2(0, 20);
		isGrounded = false;

		source.PlayOneShot(jump, 1f);
	}

	private void DinoDied()
	{
		isDead = true;
		anim.SetTrigger("dead");
		gameOverText.SetActive(true);

		source.PlayOneShot(dead, 1f);
	}

	private void CheckScore()
	{
		score++;
		scoreText.text = ( (int) (score / 5) ).ToString();

		if(score % 500 == 0)
		{
			source.PlayOneShot(scoreSound, 1f);
		}
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
		if(collision.gameObject.tag == "background")
		{
			isGrounded = true;
		}

		if(collision.gameObject.tag == "obstacle")
		{
			DinoDied();
		}
	}


}
