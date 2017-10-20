using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Entity : MonoBehaviour {

	protected TreeStats stats; 
	protected SpecialAction especial;
	protected ActionSystem actionManager;

	void Start () {}

	public bool isDie (){
		return stats.isDie ();
	}

	public abstract float actionSpeed();

	public abstract void myTurn();

	public abstract void selectAction ();

	// tal vez cambie esta.
	public abstract void applyAction (Action action);


	//No se si se usará.
	public abstract void receiveAction (Action enemyAction);

	public TreeStats getStats(){
		return stats;
	}

}
