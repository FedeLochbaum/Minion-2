using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Entity : MonoBehaviour {

	protected TreeStats stats; 
	protected SpecialAction especial;
	protected ActionManager actionManager;

	void Start () {}

	public bool isDie (){
		return stats.isDie ();
	}

	public abstract float actionSpeed();

	public abstract void myTurn();

	public abstract void selectAction ();

	public abstract void applyAction (Action action);

	public abstract void receiveAction (Action enemyAction);

}
