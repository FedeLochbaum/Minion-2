using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poison : Curse {

	public Poison() : base(3){
	}

	public new float affectHp(float hp){
		return hp - (hp * 0.5f);
	}

	public override Effect copy () {
		return new Poison ();
	}
}
