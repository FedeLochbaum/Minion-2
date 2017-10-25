using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FleeRate : LeafStat {

	public FleeRate(NodeStat root) :base(root) {}

	public void update(){
		value = root.getValue ();
	}
}
