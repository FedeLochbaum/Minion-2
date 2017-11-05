using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aragorn : Player {

	public Aragorn() : base("Aragorn"){
		Spell protect = new EffectSpell (stats, new Protect(15f), 30f, "Protect");
		magicSkills.Add (protect);
	}
}
