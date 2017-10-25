using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vitality : NodeStat {

	private EffectResistences resistences;
	private MaxHP maxHP;
	private HPRecovery hpRecovery;


	public Vitality() :base(){
		// Luego ver como hacer que las hojas tengan un calculo diferente dependiendo el padre
		value = 25;
		// resistences no es una leaf
		resistences = new EffectResistences (value);
		maxHP = new MaxHP (this);
		hpRecovery = new HPRecovery (maxHP);
		addDependentStat (resistences);
		addDependentStat (maxHP);
		addDependentStat (hpRecovery);
		update ();
	}

	public bool isDie(){
		return maxHP.isDie ();
	}
}
