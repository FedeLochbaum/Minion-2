using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Entity : MonoBehaviour {

	protected TreeStats stats; 
	protected SpecialAction especial;
	protected ActionSystem actionSystem;

	void Start () {
		actionSystem = GameObject.FindObjectOfType<ActionSystem> ();
	}

	public bool isDie (){
		return stats.isDie ();
	}

	public abstract float actionSpeed();

	public void myTurn(){
		// por ahora solo consiste en esto mismo.
		selectAction ();
	}

	public abstract void selectAction ();

	public void applyAction (Action action){
		actionSystem.ApplyAction (action);
	}
		
	//No se si se usará.
	//public abstract void receiveAction (Action enemyAction);

	public TreeStats getStats(){
		return stats;
	}

}
