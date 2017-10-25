using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Effect : MonoBehaviour {

	private int turns;

	public Effect(int turns){
		this.turns = turns;	
	}

	public void update(Stats stats){
		if (turns > 0) {
			turns--;
		} else {
			stats.removeEffect (this);
		}
	}
}
