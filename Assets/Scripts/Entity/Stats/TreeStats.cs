using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeStats : MonoBehaviour {

	private List<Effect> effects;

	private List<NodeStat> nodes;
	// Stats principales
	private Strength str;
	private Agility agi;
	private Vitality vit;
	private Intelligence inte;
	private Dexterity dex;
	private Luck luk;


	public TreeStats(){
		effects = new List<Effect> ();

		str  = new Strength ();
		agi  = new Agility ();
		vit  = new Vitality ();
		inte = new Intelligence ();
		dex  = new Dexterity ();
		luk  = new Luck ();
		// simplemente para utilizar foreach. (sino, chain of responsability)
		nodes = new List<NodeStat>{ str, agi, vit, inte, dex, luk };
	}

	public PhysicalDamage getPhysicalDamage (){
		// falta implementar.
		return new PhysicalDamage (this, 0.5f, 3f);
	}

	public MagicalDamage getMagicalDamage (){
		// falta implementar.
		return new MagicalDamage (this, 0.1f, 2f);
	}

	public void takeDamage(float finalDamage){
		// falta implementar.
	}

	public void updateTurn(){
		//Al principio de cada turno.
		foreach(NodeStat stat in nodes){
			stat.updateEffects(effects);
		}
	}

	public bool isDie (){
		return vit.isDie();
	}

	public float actionSpeed(){
		return agi.attackSpeed();
	}

	public void applyEffect(Effect effect){
		effects.Add (effect);
	}

	public void removeEffect(Effect effect){
		effects.Remove (effect);
	}
}
