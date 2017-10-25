using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats : MonoBehaviour {

	private Calculator calculator;

	// Stats principales
	private float str;
	private float agi;
	private float vit;
	private float inte;
	private float dex;
	private float luk;


	public Stats(){
		str = 25f;
		agi = 25f;
		vit  = 25f;
		inte = 25f;
		dex  = 25f;
		luk  = 25f;
		calculator = new Calculator ();
	}

	public PhysicalDamage getPhysicalDamage (){
		return new PhysicalDamage (this, calculator.getMinPhysicalDamage(), calculator.getMaxPhysicalDamage());
	}

	public MagicalDamage getMagicalDamage (){
		return new MagicalDamage (this, calculator.getMinMagicalDamage(), calculator.getMaxMagicalDamage());
	}

	public void takeDamage(float finalDamage){
		calculator.takeDamage (finalDamage);
	}

	public void updateTurn(){
		// le da apply a los effects
		calculator.updateEffects ();
	}

	public bool isDie (){
		return calculator.isDie();
	}

	public float actionSpeed(){
		return calculator.attackSpeed();
	}

	public void applyEffect(Effect effect){
		calculator.addEffect (effect);
	}

	public void removeEffect(Effect effect){
		calculator.removeEffect (effect);
	}
}
