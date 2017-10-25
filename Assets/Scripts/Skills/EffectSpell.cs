using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectSpell : Spell {

	private Effect effect;

	public EffectSpell(Stats stats, Effect effect, float cost): base(stats, cost){
		this.effect = effect;
	}

	public override void apply(Entity entity){
		playerStats.reduceSp (cost);
		entity.getStats ().applyEffect (effect);
	}
}
