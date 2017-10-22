using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectSpell : Spell {
	// no posee damage, tiene un efecto

	public EffectSpell(TreeStats stats): base(stats){}

	public override void apply(Entity entity){}
}
