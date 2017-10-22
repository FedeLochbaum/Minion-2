using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Effect : MonoBehaviour {

	private int turns;

	public Effect(int turns){
		this.turns = turns;	
	}

	public void update(TreeStats stats){
		if (turns > 0) {
			applyEffect (stats);
			turns--;
		}
	}

	public abstract void applyEffect (TreeStats stats);
}
