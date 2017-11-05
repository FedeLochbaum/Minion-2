using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Netero : Player {

	public Netero() : base("Netero") {
		Spell palmOfBuddha = new OffensiveSpell (stats, 20f, "Palm of Buddha");
		Spell nen = new EffectSpell (stats, new Attack(25f, 5), 10f, "Nen");
		magicSkills.Add (palmOfBuddha);
		magicSkills.Add (nen);

		special = new SpecialSkill (stats, 50f, new List<Spell> {new EffectSpell (stats, new OccultPower(), 0f, "") }, "OccultPower");
	}

}
