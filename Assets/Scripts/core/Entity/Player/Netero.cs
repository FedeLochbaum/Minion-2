using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Netero : Player {

	public Netero() : base("Netero"){
	}

	void Start () {
		Spell palmOfBuddha = new OffensiveSpell (stats, 20f);
		Spell nen = new EffectSpell (stats, new Attack(25f, 5), 10f);
		magicSkills.Add (palmOfBuddha);
		magicSkills.Add (nen);

		special = new SpecialSkill (stats, 50f, new List<Spell> {new EffectSpell (stats, new OccultPower(), 0f) });
	}
}
