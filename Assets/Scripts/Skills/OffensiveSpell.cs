using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OffensiveSpell : Spell {

	private MagicalDamage magicalDamage;

	public OffensiveSpell(TreeStats stats, RangeInt rangeDamage) : base(stats) {
		magicalDamage = new MagicalDamage (stats, rangeDamage);
	}

	public void apply(Entity entity){
		magicalDamage.applyDamage (entity);
	}
}
