using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatusMATK : LeafStat {

	public StatusMATK(NodeStat root) :base(root) {}

	public new void update(){
		value = root.getValue ();
	}
}
