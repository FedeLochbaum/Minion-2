using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : Blessing {
	
	private float attack;

	public Attack(float attack, int turns) : base(turns) {
		this.attack = attack;
	}

	public new float affectPhysicalDamage(float dmg){
		return dmg + attack;
	}
}
