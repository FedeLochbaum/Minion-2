using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Intelligence : NodeStat {

	private StatusMATK statusMATK;
	private MaxSP maxSp;
	private SPRecovery spRecovery;
	private SoftMDEF mdef;

	public Intelligence() :base(){
		// Luego ver como hacer que las hojas tengan un calculo diferente dependiendo el padre
		value = 25;
		statusMATK = new StatusMATK (this);
		maxSp = new MaxSP (this);
		spRecovery = new SPRecovery (this);
		mdef = new SoftMDEF (this);
		addDependentStat (statusMATK);
		addDependentStat (maxSp);
		addDependentStat (spRecovery);
		addDependentStat (mdef);
		update ();
	}
}
