using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Effect : MonoBehaviour {

	private int turns;

	public Effect(int turns){
		this.turns = turns;	
	}

	public void update(Stats stats){
		if (turns > 0) {
			turns--;
		} else {
			stats.removeEffect (this);
		}
	}

	public float affectPhysicalDefense(float def){
		return def;
	}

	public float affectMagicalDefense(float def){
		return def;
	}

	public float affectAttackSpeed(float attackS){
		return attackS;
	}

	public float affectMagicalDamage(float dmg){
		return dmg;
	}

	public float affectPhysicalDamage(float dmg){
		return dmg;
	}

	public float affectHp(float hp){
		return hp;
	}

	public float affectSp(float sp){
		return sp;
	}
}
