using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectSpell : Spell {

	private Effect effect;

	public EffectSpell(Stats stats, Effect effect, float cost, string nameSpell): base(stats, cost, nameSpell){
		this.effect = effect;
	}

	public override void apply(Entity entity){
		if (playerStats.getSp () >= cost) {
			playerStats.reduceSp (cost);
			entity.getStats ().applyEffect (effect);
		}
	}
}
