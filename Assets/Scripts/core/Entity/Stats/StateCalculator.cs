using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateCalculator : Calculator {

	private float hp;
	private float sp;
	// Faltaria aplicar las resistencias.
	public StateCalculator(Stats stats) : base(stats){
		hp = maxHp();	
		sp = maxSp();
	}

	public float maxHp(){
		return Mathf.Floor( 35f * (1 + stats.getVit() * 0.01f));
	}

	public float maxSp(){
		return Mathf.Floor( 10f * (1 + stats.getInt() * 0.01f));
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

	public void hpRecovery(){
		hp = hp + Mathf.Floor((Mathf.Max( 1, Mathf.Floor( maxHp() / 200) )) + Mathf.Floor(stats.getVit() / 5));
	}

	public void spRecovery(){
		sp = sp + Mathf.Floor(1 + (Mathf.Floor( maxSp() / 100 )) + Mathf.Floor(stats.getInt() / 6));
	}

	public override void update(){
		affectStateValues ();
		hpRecovery ();
		spRecovery ();
		updateEffects ();	
	}
}
