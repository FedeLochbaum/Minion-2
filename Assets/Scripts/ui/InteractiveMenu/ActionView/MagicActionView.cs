using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.UIElements;
using UnityEngine.UI;

public class MagicActionView : ActionView {

	private bool isSpellSelected;

	GameObject spellsUi;

	void Start () {
		selected = false;
		players = GameObject.FindGameObjectsWithTag ("playerInfo");
		enemies = GameObject.FindGameObjectsWithTag ("enemyInfo");
		actual = players [0].GetComponent<ListController> ();
		spellsUi = GameObject.FindGameObjectWithTag ("skills");
		isSpellSelected = false;
	}

	void Update () {
		if (selected) {
			checkSelection ();
			if (isSpellSelected) {
				checkTypeTarget ();
				checkSelectionTarget ();
				checkIfSelectActualTarget ();
			} else {
				checkSpellSelected ();
			}
		}
	}

	public void checkSpellSelected(){
		// Checkear skill que se selecciona
	}
		
	public void checkIfSelectActualTarget(){
		if (Input.GetKey (KeyCode.X)) {
			selected = false;
			// falta obtener el numero de skill
			player.selectMagicalAction (0, new List<Entity>{actual.entity});
			actual.disablePointer ();
		}
	}

	public new void selection(Player player){
		selected = true;
		this.player = player;

		List<Spell> playerSpells = player.getMagicalSkills ();
		foreach(Spell spell in playerSpells) {
			// Agregar skills 
		}
	}

}
