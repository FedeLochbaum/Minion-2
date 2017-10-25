using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefensiveCalculator : Calculator {

	public DefensiveCalculator(Stats stats) : base(stats){
	}

	public float reduceMagicalDamage(float damage){
		return 1;
	}

	public float reducePhysicalDamage(float damage){
		return 1;
	}

	public override void update(){
		updateEffects ();
	}
}
