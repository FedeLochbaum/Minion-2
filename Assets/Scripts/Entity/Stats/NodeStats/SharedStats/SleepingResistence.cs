using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SleepingResistence : LeafStat {
	
	public SleepingResistence(NodeStat root) :base(root) {}

	public new void update(){
		value = root.getValue ();
	}
}
