using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Agility : NodeStat {

	private AttackSpeed attackSpeedN;
	private FleeRate fleeRate;

	public Agility() :base(){
		value = 25;
		attackSpeedN = new AttackSpeed (this);
		fleeRate = new FleeRate (this);
		addDependentStat (attackSpeedN);
		addDependentStat (fleeRate);
		update ();
	}
		
	public float attackSpeed() {
		return attackSpeedN.getValue();
	}


}
