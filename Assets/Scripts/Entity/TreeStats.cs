using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeStats : MonoBehaviour {

	// Aun no tiene nada. Cambiar todo luego

	public bool isDie (){
		return false;
	}

	public PhysicalDamage getPhysicalDamage (){
		return new PhysicalDamage (this, 0.5f, 3f);
	}

	public MagicalDamage getMagicalDamage (){
		return new MagicalDamage (this, 0.1f, 2f);
	}

	public void takeDamage(float finalDamage){}

	public void applyEffect(Effect effect){
		// Podria ponerlo en una lista de efectos y a estos decirles decirles update desp de cada turno
	}

	public void updateTurn(){
		// Updatea efectos
	}

	public float actionSpeed(){
		return 1f;
	}
}
