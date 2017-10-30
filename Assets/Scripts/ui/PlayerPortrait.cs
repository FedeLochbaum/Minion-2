using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPortrait : MonoBehaviour {

	public void load(Entity entity){
		gameObject.GetComponent<GUIText>().text = entity.getName ().ToString ();
	}
}
