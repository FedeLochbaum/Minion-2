using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OffensiveSpell : Spell {

	private MagicalDamage magicalDamage;

	public OffensiveSpell(Stats stats, float minDamage, float maxDamage, float cost) : base(stats, cost) {
		magicalDamage = new MagicalDamage (stats, minDamage, maxDamage);
	}

	public override void apply(Entity entity){
		playerStats.reduceSp (cost);
		magicalDamage.applyDamage (entity);
	}
}
