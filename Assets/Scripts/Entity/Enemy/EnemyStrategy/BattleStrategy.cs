using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BattleStrategy : MonoBehaviour {

	public abstract Action getBestAction (Entity creator, List<Entity> enemies);

	public abstract List<Entity> selectTarget (List<Entity> enemies);
}
