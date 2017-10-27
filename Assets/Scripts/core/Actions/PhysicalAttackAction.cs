using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicalAttackAction : AffectAction {

	public PhysicalAttackAction(Entity creator, List<Entity> affectedEntities) : base(creator, affectedEntities){
		
	}

	public override void apply (){
		PhysicalDamage physicalDamage = creator.getStats ().getPhysicalDamage ();
		affectedEntities.ForEach( entity => physicalDamage.applyDamage(entity));
	}
}
