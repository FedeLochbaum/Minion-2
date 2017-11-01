using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTurn : MonoBehaviour {

	private PlayerHealthBar playerHealthBar;
	private PlayerEnergyBar playerEnergyBar;

	void Start () {
		playerHealthBar = gameObject.GetComponent<PlayerHealthBar> ();
		playerEnergyBar = gameObject.GetComponent<PlayerEnergyBar> ();
	}

	public void next(Entity entity){
		playerHealthBar.load (entity);
		playerEnergyBar.load (entity);
	}
}
