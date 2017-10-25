using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Luck : NodeStat {

	private CriticalHitRate criticalHitRate;
	private StatusATK statusATK;
	private HitRate hitRate;
	private StatusMATK statusMATK;

	public Luck() :base(){
		// Luego ver como hacer que las hojas tengan un calculo diferente dependiendo el padre
		value = 25;
		criticalHitRate = new CriticalHitRate (this);
		statusATK = new StatusATK (this);
		hitRate = new HitRate (this);
		statusMATK = new StatusMATK (this);
		addDependentStat (criticalHitRate);
		addDependentStat (statusATK);
		addDependentStat (hitRate);
		addDependentStat (statusMATK);
		update ();
	}
}
