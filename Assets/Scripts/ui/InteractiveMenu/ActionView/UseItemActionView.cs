using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseItemActionView : ActionView {

	void Start () {
		selected = false;
	}

	void Update () {
		if (selected) {
			checkSelection ();
		}
	}

	public new void selection(Player player){
		//Falta implementar Items
		//selected = true;
	}
}
