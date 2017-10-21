using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Spell : MonoBehaviour {

	protected TreeStats playerStats;

	public Spell(TreeStats stats){
		playerStats = stats;
	}

	public abstract void apply (Entity entity);
}
