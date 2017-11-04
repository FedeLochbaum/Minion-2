using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionView : MonoBehaviour {

	public GameObject teamInfo;

	private Player actualPlayer;
	private TeamInfoContainer info;
	private List<Entity> players, enemies;
	private ActionView actualActionView;
	private bool selection;

	void Start () {
		info = teamInfo.GetComponent<TeamInfoContainer> ();
		resetActionView ();
		selection = false;
	}

	void Update () {
		checkSelectActions ();
	}

	public void checkSelectActions (){
		if (!selection) {
			if (Input.GetKey (KeyCode.UpArrow)) {
				actualActionView = actualActionView.back ();
				activeActionSelector ();
			}

			if (Input.GetKey (KeyCode.DownArrow)) {
				actualActionView = actualActionView.next ();
				activeActionSelector ();
			}

			if (Input.GetKey (KeyCode.X)) {
				selection = true;
				actualActionView.selection (actualPlayer, players, enemies);
			}
		}
	}

	public void resetActionView(){
		if (actualActionView != null) {
			actualActionView.disablePointer ();
		}
		actualActionView = GetComponentInChildren<AttackActionView> ();
	}

	public void restart(){
		selection = false;
		resetActionView ();
		activeActionSelector ();
	}

	public void load(List<Entity> players, List<Entity> enemies) {
		this.players = players;
		this.enemies = enemies;

		info.loadPlayers (players);
		info.loadEnemies (enemies);
	}

	public void activeActionSelector (){
		actualActionView.activePointer ();
	}

	public void selectAction(Player player){
		actualPlayer = player;
		restart ();
	}
}
