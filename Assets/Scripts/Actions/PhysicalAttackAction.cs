using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicalAttackAction : AffectAction {

	public void apply (){
		float physicalDamage = creator.getStats ().getPhysicalDamage ();
		affectedEntities.ForEach( entity => entity.getStats().takePhysicalDamage(physicalDamage));
	}
}
