using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicalDamage : Damage {
	// No se si sera necesario.

	public PhysicalDamage(Stats stats, float minDamage, float maxDamage) : base(stats, minDamage, maxDamage) {
	}

	public void applyDamage(Entity entity){
		entity.getStats().takePhysicalDamage (generateDamage ());
	}
}
