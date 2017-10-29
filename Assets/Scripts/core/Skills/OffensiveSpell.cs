using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OffensiveSpell : Spell {
	
	public OffensiveSpell(Stats stats, float cost) : base(stats, cost) {
	}

	public override void apply(Entity entity){
		if (playerStats.getSp () >= cost) {
			playerStats.reduceSp (cost);
			playerStats.getMagicalDamage().applyDamage (entity);
		}
	}
}
