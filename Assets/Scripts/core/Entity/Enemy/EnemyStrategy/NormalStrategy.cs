using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalStrategy : BattleStrategy {

	public override Action getBestAction (Entity creator, List<Entity> enemies){
		List<Spell> spells = creator.getMagicalSkills ();
		List<Entity> targets = selectTargets (enemies);

		if (spells.Count > 0) {
			int spellId = Random.Range (0, spells.Count);
			if (creator.canUseSpell (spells [spellId])) {
				return new MagicalAction (creator, targets, spells [spellId]);
			}
		}
		return new PhysicalAttackAction (creator, targets);
	}

	public override List<Entity> selectTargets (List<Entity> enemies){
		// Selecciona al de menor vida.
		Entity target = enemies[0];

		foreach(Entity target2 in enemies){
			float hpTg2 = target2.getStats ().getHp ();
			float hpTg1 = target.getStats ().getHp ();
			if (hpTg2 <= hpTg1) {
				target = target2;
			}
		}

		return new List<Entity> { target };
	}

	public override float getExperience(){
		return 2500f;
	}
}
