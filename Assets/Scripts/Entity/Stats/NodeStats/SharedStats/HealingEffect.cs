using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealingEffect : LeafStat {

	public HealingEffect(NodeStat root) :base(root) {}

	public new void update(){
		value = root.getValue ();
	}
}
