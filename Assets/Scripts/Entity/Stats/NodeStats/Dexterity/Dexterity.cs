using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dexterity : NodeStat {

	private StatusATK statusATK;
	private HitRate hitRate;

	public Dexterity() :base(){
		// Luego ver como hacer que las hojas tengan un calculo diferente dependiendo el padre
		value = 25;
		statusATK = new StatusATK (this);
		hitRate = new HitRate (this);
		addDependentStat (statusATK);
		addDependentStat (hitRate);
		update ();
	}
}
