using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Burn : Curse {

	private float fireDamage;

	public Burn(float fireDamage) : base(5) {
		this.fireDamage = fireDamage;
	}

	public new float affectHp(float hp){
		return hp - fireDamage;
	}

	public override Effect copy () {
		return new Burn (fireDamage);
	}
}
