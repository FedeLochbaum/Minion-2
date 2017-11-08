using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicalDamage : Damage {

	public PhysicalDamage(Stats stats, float minDamage, float maxDamage) : base(stats, minDamage, maxDamage) {
	}

	public void applyDamage(Entity entity){
		float damage = generateDamage ();
		Debug.Log (playerStats.getEntity ().getName() +" aplica daño fisico = " + damage.ToString() + " a : " + entity.getName());
		entity.getStats().takePhysicalDamage (damage);
	}
}
