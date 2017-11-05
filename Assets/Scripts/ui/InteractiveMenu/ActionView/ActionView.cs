﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ActionView : MonoBehaviour {

	public GameObject pointer;

	public GameObject nextObject;

	public GameObject backObject;

	protected bool selected;

	public void checkSelection(){
		if (Input.GetKey (KeyCode.Z)) {
			GetComponentInParent<OptionView> ().restartSelection ();
		}
	}

	public ActionView next(){
		disablePointer ();
		return nextObject.GetComponent<ActionView> ();
	}

	public ActionView back(){
		disablePointer ();
		return backObject.GetComponent<ActionView> ();
	}

	public abstract void selection(Player player, List<Entity> players, List<Entity> enemies);

	public void activePointer(){
		pointer.SetActive (true);
	}

	public void disablePointer(){
		pointer.SetActive (false);
	}
}
