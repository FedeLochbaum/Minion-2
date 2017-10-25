using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpecialSkill : Spell {

	public SpecialSkill(Stats stats, float cost) : base(stats, cost){
		// Aun no definí como se ira a implementar las habilidades especiales. Podria tener una lista de spells
	}

	public override void apply(Entity entity){
		// aplica N spells sobre el enemigo.
	}
}
