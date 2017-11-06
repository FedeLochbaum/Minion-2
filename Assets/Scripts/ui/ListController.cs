using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ListController : MonoBehaviour {

	public GameObject nextObject;

	public GameObject backObject;

	public GameObject pointer;

	public GameObject objectSprite;

	public Entity entity;

	public void activeSprite() {
		objectSprite.SetActive (true);

		objectSprite.GetComponent<Image> ().sprite = entity.getSprite ();
	}

	public void activePointer(){
		pointer.SetActive (true);
	}

	public void disablePointer(){
		pointer.SetActive (false);
	}

	public ListController next(){
		disablePointer ();
		ListController next = nextObject.GetComponent<ListController> ();
		if (!next.isActiveAndEnabled) {
			return next.next ();
		}
		return next;
	}

	public ListController back(){
		disablePointer ();
		ListController back = backObject.GetComponent<ListController> ();
		if (!back.isActiveAndEnabled) {
			return back.back ();
		}
		return back;
	}
}
