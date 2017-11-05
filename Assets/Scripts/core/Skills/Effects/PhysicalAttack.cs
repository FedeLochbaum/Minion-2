using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicalAttack : Blessing {
	
	private float attack;

	public PhysicalAttack(float attack, int turns) : base(turns) {
		this.attack = attack;
	}

	public new float affectPhysicalDamage(float dmg){
		return dmg + attack;
	}
}
