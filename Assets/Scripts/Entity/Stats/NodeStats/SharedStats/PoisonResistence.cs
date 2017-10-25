using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoisonResistence : LeafStat {

	public PoisonResistence(NodeStat root) :base(root) {}

	public new void update(){
		value = root.getValue ();
	}
}
