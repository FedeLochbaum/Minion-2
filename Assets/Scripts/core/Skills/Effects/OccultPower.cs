using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OccultPower : Blessing {

	public OccultPower() : base(2) {}

	public new float affectPhysicalDefense(float def){
		return def / 2;
	}

	public new float affectMagicalDefense(float def){
		return def / 2;
	}

	public new float affectAttackSpeed(float attackS){
		return attackS * 2;
	}

	public new float affectMagicalDamage(float dmg){
		return dmg / 2;
	}

	public new float affectPhysicalDamage(float dmg){
		return dmg * 2;
	}

	public new float affectHp(float hp){
		return hp / 2;
	}

	public new float affectSp(float sp){
		return sp / 2;
	}

	public override Effect copy () {
		return new OccultPower ();
	}
}
