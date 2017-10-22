using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Entity {

	void Start () {
		stats = new TreeStats ();
	}

	void Update () {
		
	}

	public override float actionSpeed ()
	{
		return stats.actionSpeed ();
	}

	public override void selectAction(){
		// UI de seleccions
	}


}
