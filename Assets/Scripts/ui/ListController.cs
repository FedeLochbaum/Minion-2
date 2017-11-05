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
		return nextObject.GetComponent<ListController> ();
	}

	public ListController back(){
		disablePointer ();
		return backObject.GetComponent<ListController> ();
	}
}
