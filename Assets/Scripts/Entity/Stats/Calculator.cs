using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calculator : MonoBehaviour {

	// tiene vida y mana
	private CalculatorState calculatorState;
	private CalculatorDamage calculatorDamage;
	private CalculatorDefense calculatorDefense;


	public Calculator(){
		calculatorState = new CalculatorState();
		calculatorDamage = new CalculatorDamage();
		calculatorDefense = new CalculatorDefense ();
	}

	public float getMinPhysicalDamage(){
		return calculatorDamage.getMinPhysicalDamage ();
	}

	public float getMaxPhysicalDamage(){
		return calculatorDamage.getMaxPhysicalDamage();
	}

	public float getMinMagicalDamage(){
		return calculatorDamage.getMinMagicalDamage ();
	}

	public float getMaxMagicalDamage(){
		return calculatorDamage.getMaxMagicalDamage ();
	}

	public void takeDamage(float finalDamage){
		calculatorState.takeDamage (calculatorDefense.reduceDamage (finalDamage));
	}

	public void updateEffects(){
		// le dice a cada efecto, applica
	}

	public bool isDie(){
		
	}

	public float attackSpeed(){
		
	}

}
