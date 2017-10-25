using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BurningResistence : LeafStat {

	public BurningResistence(NodeStat root) :base(root) {}

	public new void update(){
		value = root.getValue () * 0.1f;
	}
}
