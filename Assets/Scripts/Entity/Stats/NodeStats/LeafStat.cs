using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeafStat : NodeStat {

	protected NodeStat root;

	public LeafStat(NodeStat root) :base() {
		this.root = root;
		update ();
	}
}
