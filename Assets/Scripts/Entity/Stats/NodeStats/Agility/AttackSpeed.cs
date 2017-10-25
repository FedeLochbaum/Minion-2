using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackSpeed : LeafStat {
	
	public AttackSpeed(NodeStat root) :base(root) {}

	public new void update(){
		value = root.getValue () / 4f;
	}
}
