using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpecialSkill : Spell {

	private List<Spell> spells;

	public SpecialSkill(Stats stats, float cost, List<Spell> spells, string nameSpell) : base(stats, cost, nameSpell){
		this.spells = spells;
	}

	public override void apply(Entity entity){
		foreach (Spell spell in spells) {
			spell.apply (entity);
		}
	}
}
