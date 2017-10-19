using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSystem : MonoBehaviour {
	//Encargado de generar los mobs, de crear notifiar un nuevo combate y de ser notifiado en caso de finalizarlo.
	//Los players podrian comunicarse con esta clase.
	private CombatSystem combatSystem;

	void Start () {
		combatSystem = new CombatSystem ();
	}

	void Update () {
		
	}


}
