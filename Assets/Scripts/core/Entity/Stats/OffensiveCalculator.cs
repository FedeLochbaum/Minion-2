using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OffensiveCalculator : Calculator {
	public OffensiveCalculator(Stats stats) : base(stats){
	}

	public float getMinPhysicalDamage(){
		float Dmg = Mathf.Floor((stats.getLevel().getLevel() / 4) + stats.getStr () + (stats.getDex () / 5) + (stats.getLuk () / 3));
		foreach (Effect effect in effects) {
			Dmg = effect.affectPhysicalDamage (Dmg);
		}
			
		return Dmg;
	}

	public float getMaxPhysicalDamage(){
		// 10% mas que el minimo damage
		return getMaxMagicalDamage() * 1.1f;
	}

	public float getMinMagicalDamage(){
		float MDmg = Mathf.Floor ( Mathf.Floor(stats.getLevel().getLevel() / 4) + stats.getInt() + Mathf.Floor(stats.getInt() / 2) + Mathf.Floor(stats.getDex() / 2) + Mathf.Floor(stats.getLuk() / 3));
		foreach (Effect effect in effects) {
			MDmg = effect.affectMagicalDamage (MDmg);
		}
			
		return MDmg;
	}

	public float getMaxMagicalDamage(){
		return getMinMagicalDamage () * 1.1f;
	}

	public float attackSpeed(){
		float Aspeed = (200 - (200 - (Mathf.Sqrt (stats.getAgi () * 9.999f + stats.getDex () * 0.19212f))));
		foreach (Effect effect in effects) {
			Aspeed = effect.affectAttackSpeed (Aspeed);
		}

		return Aspeed;
	}

	public override void update(){
		updateEffects ();
	}
}
