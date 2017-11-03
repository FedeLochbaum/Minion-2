using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionView : MonoBehaviour {

	public GameObject teamInfo;

	private TeamInfoContainer info;
	private List<Entity> players, enemies;

	void Start () {
		info = teamInfo.GetComponent<TeamInfoContainer> ();
	}

	public void load(List<Entity> players, List<Entity> enemies) {
		this.players = players;
		this.enemies = enemies;

		info.loadPlayers (players);
		info.loadEnemies (enemies);
	}
}
