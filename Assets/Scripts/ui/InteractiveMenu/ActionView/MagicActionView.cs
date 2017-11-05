using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicActionView : ActionView {

	void Start () {
		selected = false;
	}

	void Update () {
		if (selected) {
			checkSelection ();
		}
	}

	public override void selection(Player player){
		selected = true;
	}
}
