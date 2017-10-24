using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeStats : MonoBehaviour {

	private List<Effect> effects;

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
	}

	public bool isDie (){
		// falta terminar
		return vit.isDie();
	}
		
	public float actionSpeed(){
		// falta terminar
		return agi.attackSpeed();
	}

	public PhysicalDamage getPhysicalDamage (){
		// falta terminar
		return new PhysicalDamage (this, 0.5f, 3f);
	}

	public MagicalDamage getMagicalDamage (){
		// falta terminar
		return new MagicalDamage (this, 0.1f, 2f);
	}

	public void takeDamage(float finalDamage){
		// falta implementar.
	}

	public void updateTurn(){
		//Al principio de cada turno.
		// No se si meterlo en una lista, no me gusta así pero quiero poder acceder a cada uno especificamente.
		str.updateEffects(effects);
		agi.updateEffects(effects);
		vit.updateEffects(effects);
		inte.updateEffects(effects);
		dex.updateEffects(effects);
		luk.updateEffects(effects);
	}

	public void applyEffect(Effect effect){
		effects.Add (effect);
	}

	public void removeEffect(Effect effect){
		effects.Remove (effect);
	}
}
