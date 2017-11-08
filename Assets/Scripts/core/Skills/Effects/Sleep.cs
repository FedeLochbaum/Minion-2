using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sleep : Curse {

	public Sleep() : base(2){
	}
		
	public override Effect copy () {
		return new Sleep ();
	}
}
