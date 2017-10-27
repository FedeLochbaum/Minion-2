using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	[Range(1, 2)]
	public float speed;
	private Animator anim;
	public GameSystem gameSystem;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		move();

	}

	private void move(){
		if (Input.GetAxis ("Horizontal") != 0 || Input.GetAxis ("Vertical") != 0) {
			var movement = new Vector3 (Input.GetAxis ("Horizontal"), Input.GetAxis ("Vertical"), 0);
			transform.position += movement * speed * Time.deltaTime;
			gameSystem.load ();
			moveAnimation ();
		} else
			idleAnimation ();
	}

	private void moveAnimation(){
		string animS = (Input.GetKey (KeyCode.RightArrow)) ? "Right" 
			: (Input.GetKey (KeyCode.LeftArrow)) ? "Left" 
			: (Input.GetKey (KeyCode.UpArrow)) ? "Up"
			: "Down";

		anim.SetTrigger (animS);
	}

	private void idleAnimation(){
		anim.SetTrigger ("Idle");
	}
}
