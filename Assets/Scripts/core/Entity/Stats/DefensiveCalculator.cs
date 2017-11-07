using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefensiveCalculator : Calculator {

	public DefensiveCalculator(Stats stats) : base(stats){
	}

	public float reduceMagicalDamage(float damage){
		float MDef = (stats.getInt () + stats.getVit () / 5 + stats.getDex () / 5 + stats.getLevel().getLevel() / 4);
		foreach (Effect effect in effects) {
			MDef = effect.affectMagicalDefense (MDef);
		}

		return applyDodgeRate(damage - MDef);
	}

	public float reducePhysicalDamage(float damage){
		float Def = (stats.getVit() / 2) + Mathf.Max ( (stats.getVit() * 0.3f), (stats.getVit () * stats.getVit () / 150f) - 1);
		foreach (Effect effect in effects) {
			Def = effect.affectPhysicalDefense (Def);
		}
			
		return applyDodgeRate(damage - Def);
	}

	public float applyDodgeRate(float damage){
		float dodgePercentage = 100 - flee() / 2;

		// Sistema de Miss
		//if (Random.Range (1, 100) <= dodgePercentage) {
		//	return 0;
		//}
		return damage;
	}

	public float flee(){
		return (stats.getLevel().getLevel() + stats.getAgi() + stats.getLuk() / 5f  * (1f - ((Random.Range(1f,4f) - 2f) * 0.1f)));
	}

	public override void update(){
		updateEffects ();
	}
}
