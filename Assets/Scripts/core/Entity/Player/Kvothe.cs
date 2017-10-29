using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kvothe : Player {

	public Kvothe() : base("Kvothe"){
	}
		
	void Start () {
		Spell fireball = new OffensiveSpell (stats, 15f, "Fire ball");
		Spell songOfWind = new EffectSpell (stats, new Velocity(3f), 10f, "Song of wind");
		magicSkills.Add (fireball);
		magicSkills.Add (songOfWind);

		special = new SpecialSkill (stats, 40f, new List<Spell> {new EffectSpell (stats, new Velocity(4f), 0f, ""), new EffectSpell (stats, new Heal(3f, 4), 0f, "")}, "Denna song");
	}
}
