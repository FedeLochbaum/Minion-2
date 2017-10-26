using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateCalculator : Calculator {

	private float hp;
	private float sp;

	public StateCalculator(Stats stats) : base(stats){
		hp = 100f;
		sp = 100f;
	}

	public bool isDie(){
		return hp <= 0;
	}

	public void takeDamage(float finalDamage){
		hp = Mathf.Max (0, hp - finalDamage);
	}

	public void reduceSp(float cost){
		sp = Mathf.Max (0, sp - cost);
	}

	public void affectStateValues(){
		foreach (Effect effect in effects) {
			hp = effect.affectHp (hp);
			sp = effect.affectSp (sp);
		}
	}

	public override void update(){
		affectStateValues ();
		updateEffects ();	
	}
}
