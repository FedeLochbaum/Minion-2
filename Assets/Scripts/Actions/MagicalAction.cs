using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicalAction : AffectAction {

	private Spell spell;

	public MagicalAction(Spell spell){
		this.spell = spell;
	}

	public void apply (){
		affectedEntities.ForEach( entity => spell.apply(entity));
	}
}
