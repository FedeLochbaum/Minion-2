using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Velocity : Blessing {

	private float bonus;

	public Velocity(float bonus) : base(3) {
		this.bonus = bonus;
	}
		
	public new float affectAttackSpeed(float attackS){
		return attackS + bonus;
	}

	public override Effect copy () {
		return new Velocity (bonus);
	}
}
