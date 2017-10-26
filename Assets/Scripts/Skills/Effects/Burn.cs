using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Burn : Curse {

	private float fireDamage;

	public Burn(float fireDamage) : base(5) {
		this.fireDamage = fireDamage;
	}

	public float affectHp(float hp){
		return hp - fireDamage;
	}
}
