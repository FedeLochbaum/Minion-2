using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CriticalHitRate : LeafStat {

	public CriticalHitRate(NodeStat root) :base(root) {}

	public new void update(){
		value = root.getValue () * 0.3f;
	}
}
