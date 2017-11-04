using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FleeActionView : ActionView {

	void Start () {
		selected = false;
	}

	void Update () {
		if (selected) {
			checkSelection ();
		}
	}

	public override void selection(Player player, List<Entity> players, List<Entity> enemies){
		selected = true;
	}
}
