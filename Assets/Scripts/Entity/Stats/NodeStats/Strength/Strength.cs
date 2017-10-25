using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Strength : NodeStat {

	private WeightLimit weightLimit;
	private StatusATK statusAttack;

	public Strength() :base(){
		value = 25;

		weightLimit = new WeightLimit (this);
		statusAttack = new StatusATK (this);
		addDependentStat (weightLimit);
		addDependentStat (statusAttack);
		update ();
	}
}
