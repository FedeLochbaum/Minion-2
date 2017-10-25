using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefensiveCalculator : Calculator {

	public DefensiveCalculator(Stats stats) : base(stats){
	}

	public float reduceMagicalDamage(float damage){
		// aplicar decremento con efectos
		return damage - (stats.getInt () + stats.getVit () / 5 + stats.getDex () / 5 + stats.level () / 4);
	}

	public float reducePhysicalDamage(float damage){
		// aplicar decremento con efectos
		return damage - (stats.getVit / 2) + Mathf.Max((stats.getVit() * 0.3), (stats.getVit() * stats.getVit() / 150) - 1);
	}

	public override void update(){
		updateEffects ();
	}
}
