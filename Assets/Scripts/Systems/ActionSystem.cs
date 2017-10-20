using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionSystem : MonoBehaviour {

	private GameSystem gameSystem;

	public ActionSystem(GameSystem gameSystem){
		this.gameSystem = gameSystem;
	}

	public void finishTurnPlayer(){
		gameSystem.finishTurnPlayer ();
	}

	public void ApplyAction(Action action){
		action.apply ();
		finishTurnPlayer ();
	}
}
