using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FleeActionView : ActionView {

	void Start () {
		selected = false;
	}

	public new void selection(Player player){
		GetComponentInParent<OptionView> ().restartSelection ();
		player.selectRunAction ();
	}
}
