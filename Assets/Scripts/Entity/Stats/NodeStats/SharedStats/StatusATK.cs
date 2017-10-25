using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatusATK : LeafStat {

	public StatusATK(NodeStat root) :base(root) {}

	public new void update(){
		value = root.getValue ();
	}
}
