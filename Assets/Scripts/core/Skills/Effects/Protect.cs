using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Protect : Blessing {

	private float bonusDefense;

	public Protect(float defense) : base(2) {
		this.bonusDefense = defense;
	}

	public float affectPhysicalDefense(float def){
		return def + bonusDefense;
	}

	public float affectMagicalDefense(float def){
		return def + bonusDefense;
	}
}
