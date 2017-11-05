using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.UIElements;
using UnityEngine.UI;

public class MagicActionView : ActionView {

	private bool isSpellSelected;

	private ListController actualSpell;

	GameObject[] spellsUi;

	void Start () {
		selected = false;
		players = GameObject.FindGameObjectsWithTag ("playerInfo");
		enemies = GameObject.FindGameObjectsWithTag ("enemyInfo");
		spellsUi = GameObject.FindGameObjectsWithTag ("spell");

		actual = players [0].GetComponent<ListController> ();
		actualSpell = spellsUi [0].GetComponent<ListController> ();
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

	public override void selection(Player player){
		selected = true;
		this.player = player;

		GameObject[] spells = GameObject.FindGameObjectsWithTag ("spell");
		List<Spell> playerSpells = player.getMagicalSkills ();

		for( int i = 0; i < playerSpells.Count; ++i ) {
			GameObject gameObjectSpell = spells [i];
			Spell spell = playerSpells [i];

			Text nameSpell = gameObjectSpell.GetComponentInChildren<Text> ();

			nameSpell.text = spell.getName () + "       " + spell.getCost ().ToString();

			gameObjectSpell.GetComponent<ListSpellController> ().spell = spell;
		}

		for (int i = playerSpells.Count; i < spells.Length; ++i) {
			GameObject gameObjectSpell = spells [i];
			Text nameSpell = gameObjectSpell.GetComponentInChildren<Text> ();
			nameSpell.text = "";
		}
	}

}
