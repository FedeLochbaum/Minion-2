using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AffectAction : Action {

	protected Entity creator;
	protected Entity[] affectedEntities;

	public AffectAction(Entity creator, Entity[] affectedEntities) {
		this.creator = creator;
		this.affectedEntities = affectedEntities;
	}

}
