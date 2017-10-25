using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OffensiveCalculator : Calculator {

	public OffensiveCalculator(Stats stats) : base(stats){
	}

	public float getMinPhysicalDamage(){
		// aplicar decremento con efectos
		return ((stats.level () / 4) + stats.getStr () + (stats.getDex () / 5) + (stats.getLuk () / 3));
	}

	public float getMaxPhysicalDamage(){
		// 10% mas que el minimo damage
		return getMaxMagicalDamage() * 1.1f;
	}

	public float getMinMagicalDamage(){
		// aplicar decremento con efectos
		return (stats.level() / 4) + stats.getInt() + (stats.getInt() / 2) + (stats.getDex() / 2) + (stats.getLuk() / 3);
	}

	public float getMaxMagicalDamage(){
		return getMinMagicalDamage () * 1.1f;
	}

	public float attackSpeed(){
		// aplicar decremento con efectos

		return (200 - (200 - (Mathf.Sqrt(stats.getAgi() * 9.999f + stats.getDex() * 0.19212f))));
	}

	public override void update(){
		updateEffects ();
	}
}
