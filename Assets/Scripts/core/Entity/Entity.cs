using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Entity : MonoBehaviour {

	protected string entityName;
	public Stats stats; 
	protected ActionSystem actionSystem;

	public Entity (string name) {
		entityName = name;
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
		selectAction ();
		stats.updateTurn ();
	}

	public abstract void selectAction ();

	public void applyAction (Action action){
		actionSystem.ApplyAction (action);
	}

	public Stats getStats(){
		return stats;
	}

}
