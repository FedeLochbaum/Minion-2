using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpecialSkill : Spell {

	private List<Spell> spells;

	public SpecialSkill(Stats stats, float cost, List<Spell> spells) : base(stats, cost){
		this.spells = spells;
	}

	public override void apply(Entity entity){
		foreach (Spell spell in spells) {
			spell.apply (entity);
		}
	}
}
