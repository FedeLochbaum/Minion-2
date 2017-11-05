using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ActionView : MonoBehaviour {

	protected GameObject[] enemies;
	protected GameObject[] players;
	protected ListController actual;

	protected Player player;

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

	public abstract void selection(Player player);

	public void activePointer(){
		pointer.SetActive (true);
	}

	public void disablePointer(){
		pointer.SetActive (false);
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
}
