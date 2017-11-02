using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Entity : MonoBehaviour {

	protected string entityName;
	public Stats stats; 
	protected ActionSystem actionSystem;
	protected GameSystem gameSystem;

	public Entity (string name) {
		entityName = name;
		stats = new Stats ();
		gameSystem = GameObject.FindObjectOfType<GameSystem> ();
		actionSystem = gameSystem.getActionSystem();
	}

	public string getName(){
		return entityName;
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
		gameSystem.finishTurnPlayer ();
	}

	public void selectAction (){}

	public void applyAction (Action action){		
		actionSystem.ApplyAction (action);
	}

	public Stats getStats(){
		return stats;
	}

	public float getExperience(){
		return 1f;
	}

}
