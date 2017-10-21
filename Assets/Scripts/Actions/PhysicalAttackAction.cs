using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicalAttackAction : AffectAction {

	public void apply (){
		PhysicalDamage physicalDamage = creator.getStats ().getPhysicalDamage ();
		affectedEntities.ForEach( entity => physicalDamage.applyDamage(entity));
	}
}
