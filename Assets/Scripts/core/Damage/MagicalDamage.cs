using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicalDamage : Damage {
	
	public MagicalDamage(Stats stats, float minDamage, float maxDamage) : base(stats, minDamage, maxDamage) {
	}

	public void applyDamage(Entity entity){
		float damage = generateDamage ();
		print (playerStats.getEntity ().getName() +" aplica daño magico = " + damage.ToString() + " a : " + entity.getName());
		entity.getStats().takeMagicalDamage (damage);
	}
}
