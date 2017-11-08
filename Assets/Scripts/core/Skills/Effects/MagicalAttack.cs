using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicalAttack : Blessing {

	private float attack;

	public MagicalAttack(float attack, int turns) : base(turns) {
		this.attack = attack;
	}

	public new float affectMagicalDamage(float dmg){
		return dmg + attack;
	}

	public override Effect copy () {
		return new MagicalAttack (attack, turns);
	}
}
