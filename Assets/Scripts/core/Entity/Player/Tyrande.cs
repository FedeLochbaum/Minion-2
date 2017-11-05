using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tyrande : Player {

	public Tyrande() : base("Tyrande") {
		Spell velocity = new EffectSpell (stats, new Velocity(1f), 10f, "Velocity");
		Spell heal = new EffectSpell (stats, new Heal(3f, 4), 15f, "Touch of Elune");
		Spell poison =  new EffectSpell (stats, new Poison(), 20f, "Poison");
		Spell protect =  new EffectSpell (stats, new Protect(10f), 40f, "Protect");

		magicSkills.Add (protect);
		magicSkills.Add (poison);
		magicSkills.Add (heal);
		magicSkills.Add (velocity);

		special = new SpecialSkill (stats, 50f, new List<Spell> {new EffectSpell (stats, new Heal(99f, 1), 0f, "")}, "For Elune");
	}

}
