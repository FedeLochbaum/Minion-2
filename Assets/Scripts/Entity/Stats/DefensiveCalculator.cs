using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefensiveCalculator : Calculator {

	public DefensiveCalculator(Stats stats) : base(stats){
	}

	public float reduceMagicalDamage(float damage){
		float MDef = (stats.getInt () + stats.getVit () / 5 + stats.getDex () / 5 + stats.level () / 4);
		foreach (Effect effect in effects) {
			MDef = effect.affectMagicalDefense (MDef);
		}

		return damage - MDef;
	}

	public float reducePhysicalDamage(float damage){
		float Def = (stats.getVit() / 2) + Mathf.Max ( (stats.getVit() * 0.3f), (stats.getVit () * stats.getVit () / 150f) - 1);
		foreach (Effect effect in effects) {
			Def = effect.affectPhysicalDefense (Def);
		}
			
		return damage - Def;
	}

	public override void update(){
		updateEffects ();
	}
}
