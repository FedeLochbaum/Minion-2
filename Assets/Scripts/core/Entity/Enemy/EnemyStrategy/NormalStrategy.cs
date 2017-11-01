using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalStrategy : BattleStrategy {

	public override Action getBestAction (Entity creator, List<Entity> enemies){
		// Falta implementar.
		return null;
	}

	public override List<Entity> selectTargets (List<Entity> enemies){
		// Falta implementar.
		return null;
	}

	public override float getExperience(){
		return 2500f;
	}
}
