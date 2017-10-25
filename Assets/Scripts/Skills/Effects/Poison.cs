using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poison : Curse {

	public Poison(int poisonTurns) : base(poisonTurns){
	}

	public override void applyEffect (Stats stats)
	{
		throw new System.NotImplementedException ();
	}
}
