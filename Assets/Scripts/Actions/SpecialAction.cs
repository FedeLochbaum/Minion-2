using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class SpecialAction : AffectAction {

	public SpecialAction (Entity creator, List<Entity> affectedEntities) : base (creator, affectedEntities){
		
	}
}
