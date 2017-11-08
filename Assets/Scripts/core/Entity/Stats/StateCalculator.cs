using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateCalculator : Calculator {

	private float hp;
	private float sp;
	// Falta aplicar las resistencias.
	public StateCalculator(Stats stats) : base(stats){
		hp = maxHp();	
		sp = maxSp();
	}
		
	public float getSp(){
		return sp;
	}
		
	public float getHp(){
		return hp;
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
		if (finalDamage > 0) {
			hp = Mathf.Max (0, hp - finalDamage);
		}
	}

	public void reduceSp(float cost){
		if (cost > 0) {
			sp = Mathf.Max (0, sp - cost);
		}
	}

	public void affectStateValues(){
		foreach (Effect effect in effects) {
			hp = effect.affectHp (hp);
			sp = effect.affectSp (sp);
		}
	}

	public new void levelUp(){
		hp = maxHp();	
		sp = maxSp();
	}

	public void hpRecovery(){
		hp = Mathf.Min(hp + Mathf.Floor((Mathf.Max( 1, Mathf.Floor( maxHp() / 200) )) + Mathf.Floor(stats.getVit() / 5)), maxHp());
	}

	public void spRecovery(){
		sp = Mathf.Min(sp + Mathf.Floor(1 + (Mathf.Floor( maxSp() / 100 )) + Mathf.Floor(stats.getInt() / 6)), maxSp());
	}

	public override void update(){
		affectStateValues ();
		hpRecovery ();
		spRecovery ();
		updateEffects ();	
	}
}
