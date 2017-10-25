using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitRate : LeafStat {

	public HitRate(NodeStat root) :base(root) {}

	public new void update(){
		value = root.getValue ();
	}
}
