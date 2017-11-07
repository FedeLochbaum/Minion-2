using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EasyStrategy : BattleStrategy {

	public override Action getBestAction (Entity creator, List<Entity> enemies){
		return new PhysicalAttackAction (creator, selectTargets (enemies));
	}

	public override List<Entity> selectTargets (List<Entity> enemies){
		Entity entity = enemies [0];
		while (entity.isDie ()) {
			entity = enemies [Random.Range (0, enemies.ToArray ().Length)];
		}

		return new List<Entity> { entity };
	}

	public override float getExperience(){
		return 1000f;
	}
}
