using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListController : MonoBehaviour {

	public GameObject nextObject;

	public GameObject backObject;

	public GameObject pointer;

	public Entity entity;

	public void activePointer(){
		pointer.SetActive (true);
	}

	public void disablePointer(){
		pointer.SetActive (false);
	}

	public ListController next(){
		disablePointer ();
		ListController next = nextObject.GetComponent<ListController> ();
		//if (next.entity == null) {
		//	next = next.next ();
		//}
		return next;
	}

	public ListController back(){
		disablePointer ();
		ListController back = backObject.GetComponent<ListController> ();
		//if (back.entity == null) {
		//	back = back.back ();
		//}
		return back;
	}
}
