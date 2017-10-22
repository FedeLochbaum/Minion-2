using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectSpell : Spell {

	private Effect effect;

	public EffectSpell(TreeStats stats, Effect effect): base(stats){
		this.effect = effect;
	}

	public override void apply(Entity entity){
		entity.getStats ().applyEffect (effect);
	}
}
