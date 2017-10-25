using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Spell : MonoBehaviour {

	protected Stats playerStats;

	public Spell(Stats stats){
		playerStats = stats;
	}

	public abstract void apply (Entity entity);
}
