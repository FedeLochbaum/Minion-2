using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poison : Curse {

	public Poison() : base(3){
	}

	public new float affectHp(float hp){
		// saca siempre el 5% de la vida actual
		return hp - (hp * 0.5f);
	}
}
