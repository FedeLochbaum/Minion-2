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
		actualSpell = spellsUi [3].GetComponent<ListController> ();
		isSpellSelected = false;
	}

	void Update () {
		if (selected) {
			checkSelection ();
			pressBack ();
			if (isSpellSelected) {
				checkTypeTarget ();
				checkSelectionTarget ();
				checkIfSelectActualTarget ();
			} else {
				checkSelectionSpell ();
				checkSpellSelected ();
			}
		}
	}

	public void pressBack(){
		if (Input.GetKeyDown (KeyCode.Z)) {
			isSpellSelected = false;
			selected = false;
			actual.disablePointer ();
			actualSpell.disablePointer ();
			restartSpellList ();
		}
	}

	public void checkSpellSelected(){

		if (Input.GetKeyDown (KeyCode.C)) {
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
		if (Input.GetKeyDown (KeyCode.X) && canUseSpell()) {
			pressBack ();
			restartSpellList ();
			player.selectMagicalAction (spellSelected, new List<Entity>{actual.entity});
		}
	}

	public bool canUseSpell() {
		return player.getStats ().getSp () >= spellSelected.getCost ();
	}

	public void restartSpellList(){
		GameObject[] spells = GameObject.FindGameObjectsWithTag ("spell");

		for( int i = 0; i < spells.Length; ++i ) {
			GameObject gameObjectSpell = spells [i];

			Text nameSpell = gameObjectSpell.GetComponentInChildren<Text> ();

			nameSpell.text = "";

			gameObjectSpell.GetComponent<ListController> ().disablePointer();
			gameObjectSpell.GetComponent<ListSpellController> ().spell = null;
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
