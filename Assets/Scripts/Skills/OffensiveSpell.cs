using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OffensiveSpell : Spell {

	private MagicalDamage magicalDamage;

	public OffensiveSpell(TreeStats stats, float minDamage, float maxDamage) : base(stats) {
		magicalDamage = new MagicalDamage (stats, minDamage, maxDamage);
	}

	public override void apply(Entity entity){
		magicalDamage.applyDamage (entity);
	}
}
