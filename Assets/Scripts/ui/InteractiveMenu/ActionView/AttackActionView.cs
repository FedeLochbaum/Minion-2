using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackActionView : ActionView {

	ListController actual;

	void Start () {
		selected = false;
		players = GameObject.FindGameObjectsWithTag ("playerInfo");
		enemies = GameObject.FindGameObjectsWithTag ("enemyInfo");
		actual = players [0].GetComponent<ListController> ();
	}

	void Update () {
		if (selected) {
			checkSelection ();
			checkTypeTarget ();
			checkSelectionTarget ();
			checkIfSelectActualTarget ();
		}
	}

	public void checkTypeTarget(){
		if (Input.GetKey (KeyCode.LeftArrow)) {
			if (actual != null) {
				actual.disablePointer ();
			}
			actual = enemies [0].GetComponent<ListController> ();
			actual.activePointer ();
		}

		if (Input.GetKey (KeyCode.RightArrow)) {
			if (actual != null) {
				actual.disablePointer ();
			}
			actual = players [0].GetComponent<ListController> ();
			actual.activePointer ();
		}
	}

	public void checkSelectionTarget(){
		if (Input.GetKey (KeyCode.UpArrow)) {
			actual = actual.back();
			actual.activePointer ();
		}

		if (Input.GetKey (KeyCode.DownArrow)) {
			actual = actual.next();
			actual.activePointer ();
		}
	}

	public void checkIfSelectActualTarget(){
		if (Input.GetKey (KeyCode.X)) {
			print ("Attack");
			player.selectPhysicalAttackAction (actual.entity);
		}
	}

	public override void selection(Player player){
		selected = true;
		this.player = player;
	}
}
