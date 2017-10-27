using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Spell : MonoBehaviour {

	protected Stats playerStats;
	protected float cost;

	public Spell(Stats stats, float cost){
		this.cost = cost;
		playerStats = stats;
	}

	public abstract void apply (Entity entity);
}
