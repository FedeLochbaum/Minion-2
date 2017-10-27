using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicalDamage : Damage {
	
	public MagicalDamage(Stats stats, float minDamage, float maxDamage) : base(stats, minDamage, maxDamage) {
	}

	public void applyDamage(Entity entity){
		entity.getStats().takeMagicalDamage (generateDamage ());
	}
}
