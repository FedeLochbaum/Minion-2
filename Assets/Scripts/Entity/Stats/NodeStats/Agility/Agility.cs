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
		dependentStats.Add (attackSpeed);
		dependentStats.Add (fleeRate);
		update ();
	}
		
	public float attackSpeed() {
		return attackSpeedN.getValue();
	}


}
