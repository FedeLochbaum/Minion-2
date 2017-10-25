using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackSpeed : LeafStat {
	
	public AttackSpeed(NodeStat root) :base(root) {}

	public void update(){
		value = root.getValue () / 4f;
	}
}
