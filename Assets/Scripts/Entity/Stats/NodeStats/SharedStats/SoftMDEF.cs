using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoftMDEF : LeafStat {
	
	public SoftMDEF(NodeStat root) :base(root) {}

	public new void update(){
		value = root.getValue () / 2f;
	}
}
