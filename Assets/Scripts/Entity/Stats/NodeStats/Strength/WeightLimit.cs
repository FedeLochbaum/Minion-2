using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeightLimit : LeafStat {

	public WeightLimit(NodeStat root) :base(root) {}

	public new void update(){
		value = root.getValue () * 30f;
	}
}
