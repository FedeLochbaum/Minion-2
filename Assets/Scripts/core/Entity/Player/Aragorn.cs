using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aragorn : Player {

	public Aragorn() : base("Aragorn"){
		Spell protect = new EffectSpell (stats, new Protect(15f), 30f, "Protect");
		Spell focus = new EffectSpell (stats, new PhysicalAttack(25f, 5), 10f, "Focused Rage");
		Spell inner = new EffectSpell (stats, new Heal(30f, 1), 10f, "Inner Rage");
		Spell mortalCombo = new OffensiveSpell (stats, 30f, "Mortal Combo");

		magicSkills.Add (protect);
		magicSkills.Add (inner);
		magicSkills.Add (focus);
		magicSkills.Add (mortalCombo);

		special = new SpecialSkill (stats, 10f, new List<Spell> {new OffensiveSpell (stats, 65f, "")}, "Mortal");
	}
}
