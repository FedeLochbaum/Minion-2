using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReduceDefense : Curse {

	private float reduce;

	public ReduceDefense(float def, int turns) : base(turns) {
		this.reduce = def;
	}
		
	public float affectPhysicalDefense(float def){
		return Mathf.Max(def - reduce, 0);
	}

	public float affectMagicalDefense(float def){
		return Mathf.Max(def - reduce, 0);
	}
}
