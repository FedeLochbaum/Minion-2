using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Netero : Player {

	public Netero() : base("Netero") {
		Spell palmOfBuddha = new OffensiveSpell (stats, 20f, "Palm of Buddha");
		Spell nen = new EffectSpell (stats, new PhysicalAttack(25f, 5), 10f, "Nen");
		Spell rdef = new EffectSpell (stats, new ReduceDefense(25f, 2), 10f, "Reduce Defense");
		Spell protect = new EffectSpell (stats, new Protect(15f), 30f, "Protect");
		magicSkills.Add (palmOfBuddha);
		magicSkills.Add (nen);
		magicSkills.Add (rdef);
		magicSkills.Add (protect);

		special = new SpecialSkill (stats, 50f, new List<Spell> {new EffectSpell (stats, new OccultPower(), 0f, "") }, "OccultPower");
	}

}
