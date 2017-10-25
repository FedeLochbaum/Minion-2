﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaxSP : LeafStat {
	
	public MaxSP(NodeStat root) :base(root) {}

	public new void update(){
		value = root.getValue ();
	}
}
