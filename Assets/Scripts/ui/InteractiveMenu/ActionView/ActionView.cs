using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ActionView : MonoBehaviour {

	public GameObject pointer;

	public GameObject nextObject;

	public GameObject backObject;

	public ActionView next(){
		desactivePointer ();
		return nextObject.GetComponent<ActionView> ();
	}

	public ActionView back(){
		desactivePointer ();
		return backObject.GetComponent<ActionView> ();
	}

	public abstract void selection(Player player, List<Entity> players, List<Entity> enemies);

	public void backToMenuSelection(){
		GetComponent<OptionView> ().restart ();
	}

	public void activePointer(){
		pointer.SetActive (true);
	}

	public void desactivePointer(){
		pointer.SetActive (false);
	}
}
