using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunAction : Action {

	// probabilidad de escapar, podria depender de los stats de los mobs
	private float probabilityOfEscape = 40f;

	private Random rand;

	public RunAction(){
		rand = new Random ();
	}

	public void apply (){
		// esto esta mal, no funciona. Deberia pedirle un random entre 0 y 100
		float chance = Random.Range ();

		if(chance <= probabilityOfEscape)
			GameObject.FindObjectOfType<GameSystem> ().finishBattle ();
	}
}
