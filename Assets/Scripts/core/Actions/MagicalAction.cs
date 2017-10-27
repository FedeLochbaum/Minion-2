using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicalAction : AffectAction {

	private Spell spell;

	public MagicalAction(Entity creator, List<Entity> affectedEntities, Spell spell) : base(creator, affectedEntities) {
		this.spell = spell;
	}

	public override void apply (){
		affectedEntities.ForEach( entity => spell.apply(entity));
	}
}
