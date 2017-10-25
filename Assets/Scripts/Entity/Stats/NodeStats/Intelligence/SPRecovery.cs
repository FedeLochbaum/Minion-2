using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SPRecovery : LeafStat {
	
	public SPRecovery(NodeStat root) :base(root) {}

	public new void update(){
		value = root.getValue () / 6f;
	}
}
