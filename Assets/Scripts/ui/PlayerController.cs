using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	[Range(1, 2)]
	public float speed;
	private Animator anim;
	public GameSystem gameSystem;
	private bool isRight;
	private int countFrames;
	private int count;

	void Start () {
		isRight = false;
		anim = GetComponent<Animator> ();
		countFrames = 50;
		count = countFrames;
	}

	void Update () {
		if (!gameSystem.getBattleSystem ().getIsBattle ()) {
			move ();
			flip ();
		}
	}

	void checkBattle () {
		if (count <= 0) {
			gameSystem.generateBattle ();
			count = countFrames;
		} else {
			count--;
		}
	}

	private void move(){
		if (Input.GetAxis ("Horizontal") != 0 || Input.GetAxis ("Vertical") != 0) {
			var movement = new Vector3 (Input.GetAxis ("Horizontal"), Input.GetAxis ("Vertical"), 0);
			transform.position += movement * speed * Time.deltaTime;
			moveAnimation ();
			checkBattle ();
		} else
			idleAnimation ();
	}

	private void moveAnimation(){
		string animS = (Input.GetKey (KeyCode.RightArrow)) ? "Right" 
			: (Input.GetKey (KeyCode.LeftArrow)) ? "Left" 
			: (Input.GetKey (KeyCode.UpArrow)) ? "Top"
			: (Input.GetKey(KeyCode.DownArrow)) ? "Down" : "Idle";

		anim.SetTrigger (animS);
	}

	private void idleAnimation(){
		anim.SetTrigger ("Idle");
	}

	private void flip(){
		float horizontal = Input.GetAxis ("Horizontal");
		if (horizontal > 0 && !isRight || horizontal < 0 && isRight) {
			isRight = !isRight;
			Vector3 scale = transform.localScale;
			scale.x *= -1;
			transform.localScale = scale;
		}
	}
}
