using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackActionView : ActionView {

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
		
	public void checkIfSelectActualTarget(){
		if (Input.GetKey (KeyCode.X)) {
			selected = false;
			player.selectPhysicalAttackAction (actual.entity);
			actual.disablePointer ();
		}
	}

	public override void selection(Player player){
		selected = true;
		this.player = player;
	}
}
