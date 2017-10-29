using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heal : Blessing {

	private float powerHeal;

	public Heal(float powerHeal, int turns) : base(turns) {
		this.powerHeal = powerHeal;
	}

	public new float affectHp(float hp){
		return hp + powerHeal;
	}
}
