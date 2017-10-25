using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaxHP : LeafStat {

	private float defaultValue, actualHp;


	public MaxHP(NodeStat root) :base(root) {
		defaultValue = 100f;
		actualHp = defaultValue;
	}

	public new void update(){
		// VALUE = max Life
		value = defaultValue + (root.getValue () * defaultValue);
	}

	public bool isDie(){
		return actualHp <= 0;
	}
}
