using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunAction : Action {

	// probabilidad de escapar, podria depender de los stats de los mobs
	private float probabilityOfEscape = 40f;

	public override void apply (){
		float chance = Random.Range(0f, 100f);

		if(chance <= probabilityOfEscape)
			GameObject.FindObjectOfType<GameSystem> ().finishBattle ();
	}
}
