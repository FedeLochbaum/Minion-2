using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTurn : MonoBehaviour {

	private PlayerPortrait playerPortrait;
	private PlayerHealthBar playerHealthBar;
	private PlayerEnergyBar playerEnergyBar;

	void Start () {
		playerPortrait = gameObject.GetComponent<PlayerPortrait> ();
		playerHealthBar = gameObject.GetComponent<PlayerHealthBar> ();
		playerEnergyBar = gameObject.GetComponent<PlayerEnergyBar> ();
	}

	public void next(Entity entity){
		playerPortrait.load (entity);
		playerHealthBar.load (entity);
		playerEnergyBar.load (entity);
	}
}
