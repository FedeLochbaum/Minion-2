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
	private bool isLoad;

	void Start () {
		info = teamInfo.GetComponent<TeamInfoContainer> ();
		resetActionView ();
		restartSelection ();
		isLoad = false;
	}

	void Update () {
		checkSelectActions ();
	}

	public void checkSelectActions (){
		if (!selection && isLoad) {
			if (Input.GetKey (KeyCode.UpArrow)) {
				actualActionView = actualActionView.back ();
				activeActionSelector ();
			}

			if (Input.GetKey (KeyCode.DownArrow)) {
				actualActionView = actualActionView.next ();
				activeActionSelector ();
			}

			if (Input.GetKey (KeyCode.RightArrow)) {
				selection = true;
				actualActionView.selection (actualPlayer);
			}
		}
	}

	public void resetActionView(){
		if (actualActionView != null) {
			actualActionView.disablePointer ();
		}
		actualActionView = GetComponentInChildren<AttackActionView> ();
	}

	public void restartSelection () {
		selection = false;
	}

	public void restart(){
		resetActionView ();
		activeActionSelector ();
		restartSelection ();
	}

	public void load(List<Entity> players, List<Entity> enemies) {
		isLoad = true;
		this.players = players;
		this.enemies = enemies;

		reload ();
	}

	public void reload(){
		info.loadPlayers (players);
		info.loadEnemies (enemies);
	}

	public void activeActionSelector (){
		actualActionView.activePointer ();
	}

	public void newTurnForSelectAction(Player player){
		actualPlayer = player;
		restart ();
	}
}
