﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Entity : MonoBehaviour {

	protected TreeStats stats; 
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

	public TreeStats getStats(){
		return stats;
	}

}
