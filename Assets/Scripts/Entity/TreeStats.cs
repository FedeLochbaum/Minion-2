using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeStats : MonoBehaviour {

	public bool isDie (){
		return false;
	}

	public PhysicalDamage getPhysicalDamage (){}

	public MagicalDamage getMagicalDamage (){}

	public void takeDamage(float finalDamage){}
}
