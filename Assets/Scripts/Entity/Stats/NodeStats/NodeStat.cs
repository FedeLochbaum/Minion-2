using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class NodeStat : MonoBehaviour {

	protected List<NodeStat> dependentStats;
	protected float value = 0;

	public NodeStat(){
		dependentStats = new List<NodeStat> ();
	}

	public void addDependentStat(NodeStat stat){
		dependentStats.Add (stat);
	}

	public void updateEffects(List<Effect> effects){
	}


}
