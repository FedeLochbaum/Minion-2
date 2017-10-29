using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aragorn : Player {

	public Aragorn() : base("Aragorn"){
	}

	void Start () {
		Spell protect = new EffectSpell (stats, new Protect(), 30f);
		magicSkills.Add (protect);

	}
}
