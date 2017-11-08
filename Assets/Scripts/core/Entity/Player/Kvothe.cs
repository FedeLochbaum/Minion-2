using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kvothe : Player {

	public Kvothe() : base("Kvothe") {
		Spell fireball = new OffensiveSpell (stats, 15f, "Fire ball");
		Spell songOfWind = new EffectSpell (stats, new Velocity(3f), 10f, "Song of wind");
		Spell waterball = new OffensiveSpell (stats, 25f, "Water ball");
		Spell memory = new EffectSpell (stats, new MagicalAttack(30f, 2), 10f, "Memory");

		magicSkills.Add (fireball);
		magicSkills.Add (waterball);
		magicSkills.Add (songOfWind);
		magicSkills.Add (memory);

		special = new SpecialSkill (stats, 10f, new List<Spell> {new EffectSpell (stats, new Velocity(4f), 0f, ""), new EffectSpell (stats, new Heal(3f, 4), 0f, "")}, "Denna song");
	}
		
}
