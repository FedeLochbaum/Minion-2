using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FleeActionView : ActionView {

	void Start () {
		selected = false;
	}

	public override void selection(Player player, List<Entity> players, List<Entity> enemies){
		GetComponentInParent<OptionView> ().restartSelection ();
		player.selectRunAction ();
	}
}
