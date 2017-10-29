using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tyrande : Player {

	public Tyrande() : base("Tyrande"){
	}

	void Start () {
		Spell velocity = new EffectSpell (stats, new Velocity(1f), 10f);
		Spell heal = new EffectSpell (stats, new Heal(3f, 4), 15f);
		Spell poison =  new EffectSpell (stats, new Poison(), 20f);
		Spell protect =  new EffectSpell (stats, new Protect(10f), 40f);

		magicSkills.Add (protect);
		magicSkills.Add (poison);
		magicSkills.Add (heal);
		magicSkills.Add (velocity);

		special = new SpecialSkill (stats, 50f, new List<Spell> {new EffectSpell (stats, new Heal(99f, 1), 0f)});
	}
}
