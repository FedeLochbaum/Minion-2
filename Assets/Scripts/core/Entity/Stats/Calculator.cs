using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Calculator : MonoBehaviour {

	protected List<Effect> effects;
	protected Stats stats;

	public Calculator(Stats stats) {
		effects = new List<Effect> ();
		this.stats = stats;
	}

	public void updateEffects(){
		foreach (Effect effect in effects) {
			effect.update (stats);
		}
	}

	public void addEffect(Effect effect){
		effects.Add (effect);
	}

	public void removeEffect(Effect effect){
		effects.Remove (effect);
	}

	// se llama a update cuando termina el turno
	public abstract void update ();

	public void levelUp(){}

	// quiero poder hacer esto.
	// effects.Select (affectPhysicalDamage).fold (f => Dmg = f (Dmg), Dmg);  
}
