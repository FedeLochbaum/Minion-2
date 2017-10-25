using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Entity : MonoBehaviour {

	protected Stats stats; 
	protected ActionSystem actionSystem;

	public Entity () {
		stats = new Stats ();
		actionSystem = GameObject.FindObjectOfType<ActionSystem> ();
	}

	public bool isDie (){
		return stats.isDie ();
	}

	public float actionSpeed ()
	{
		return stats.actionSpeed ();
	}

	public void myTurn(){
		stats.updateTurn ();
		selectAction ();
	}

	public abstract void selectAction ();

	public void applyAction (Action action){
		actionSystem.ApplyAction (action);
	}

	public Stats getStats(){
		return stats;
	}

}
