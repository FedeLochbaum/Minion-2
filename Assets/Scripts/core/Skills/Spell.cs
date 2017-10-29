using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Spell : MonoBehaviour {

	protected string nameSpell;
	protected Stats playerStats;
	protected float cost;

	public Spell(Stats stats, float cost, string nameSpell){
		this.cost = cost;
		this.nameSpell = nameSpell;
		playerStats = stats;
	}

	public abstract void apply (Entity entity);
}
