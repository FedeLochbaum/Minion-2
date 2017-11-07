﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpecialActionView : ActionView {

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
			pressBack ();
		}
	}

	public void pressBack(){
		if (Input.GetKey (KeyCode.Z)) {
			actual.disablePointer ();
			selected = false;
		}
	}

	public void checkIfSelectActualTarget(){
		if (Input.GetKey (KeyCode.X) && canUseSpell()) {
			selected = false;
			player.selectSpecialAction (new List<Entity>{actual.entity});
			actual.disablePointer ();
		}
	}

	public bool canUseSpell() {
		return player.getStats ().getSp () >= player.getSpecialSkill().getCost ();
	}

	public override void selection (Player player) {
		selected = true;
		this.player = player;
	}
}
