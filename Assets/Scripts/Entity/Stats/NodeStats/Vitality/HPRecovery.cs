using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPRecovery : LeafStat {
	
	public HPRecovery(NodeStat root) :base(root) {}

	public new void update(){
		value = root.getValue () / 200f;
	}
}
