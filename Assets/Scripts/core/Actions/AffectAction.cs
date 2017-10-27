using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AffectAction : Action {

	protected Entity creator;
	protected List<Entity> affectedEntities;

	public AffectAction(Entity creator, List<Entity> affectedEntities) {
		this.creator = creator;
		this.affectedEntities = affectedEntities;
	}

}
