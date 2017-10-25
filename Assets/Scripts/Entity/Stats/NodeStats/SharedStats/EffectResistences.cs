using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectResistences : NodeStat {

	private HealingEffect healingEffect;
	private PoisonResistence poisonResistence;
	private SleepingResistence sleepingResistence;
	private BurningResistence burningResistence;

	public EffectResistences(float vitValue) :base(){
		// Luego ver como hacer que las hojas tengan un calculo diferente dependiendo el padre
		value = vitValue;
		healingEffect = new HealingEffect (this);
		poisonResistence = new PoisonResistence (this);
		sleepingResistence = new SleepingResistence (this);
		burningResistence = new BurningResistence (this);
		addDependentStat (healingEffect);
		addDependentStat (poisonResistence);
		addDependentStat (sleepingResistence);
		addDependentStat (burningResistence);
		update ();
	}
}
