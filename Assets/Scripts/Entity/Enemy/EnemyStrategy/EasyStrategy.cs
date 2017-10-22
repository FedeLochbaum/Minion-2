using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EasyStrategy : BattleStrategy {

	public override Action getBestAction (Entity creator, List<Entity> enemies){
		return new PhysicalAttackAction (creator, selectTarget (enemies));
	}

	public override List<Entity> selectTarget (List<Entity> enemies){
		return new List<Entity> { enemies [Random.Range (0, enemies.ToArray ().Length)] };
	}
}
