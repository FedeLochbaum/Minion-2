using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.UIElements;
using UnityEngine.UI;

public class MagicActionView : ActionView {

	private bool isSpellSelected;

	private ListController actualSpell;

	private Spell spellSelected;

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
				pressBack ();
			} else {
				checkSpellSelected ();
				pressBack ();
			}
		}
	}

	public void pressBack(){
		if (Input.GetKey (KeyCode.Z)) {
			actualSpell.disablePointer ();
			actual.disablePointer ();
			isSpellSelected = false;
			selected = false;
		}
	}

	public void checkSpellSelected(){
		checkSelectionSpell ();

		if (Input.GetKey (KeyCode.RightArrow)) {
			isSpellSelected = true;
			spellSelected = actualSpell.GetComponent<ListSpellController> ().spell;
		}
	}

	public void checkSelectionSpell(){
		if (Input.GetKey (KeyCode.UpArrow)) {
			actualSpell = actualSpell.back();
			actualSpell.activePointer ();
		}

		if (Input.GetKey (KeyCode.DownArrow)) {
			actualSpell = actualSpell.next();
			actualSpell.activePointer ();
		}
	}
		
	public void checkIfSelectActualTarget(){
		if (Input.GetKey (KeyCode.X)) {
			selected = false;
			player.selectMagicalAction (spellSelected, new List<Entity>{actual.entity});
			actual.disablePointer ();
		}
	}

	public override void selection(Player player){
		isSpellSelected = false;
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
