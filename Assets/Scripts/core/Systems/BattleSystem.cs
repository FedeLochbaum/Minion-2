using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

public class BattleSystem : MonoBehaviour {

	private TurnSystem turnSystem;
	private BattlePanel battlePanel;
	private List<Entity> playerEntities;
	private List<Entity> enemyEntities;
	private bool isBattle;
	private GameSystem gameSystem;

	public BattleSystem(GameSystem gameSystem, Canvas canvas){
		this.gameSystem = gameSystem;
		battlePanel = canvas.GetComponent<BattlePanel>();
		turnSystem = new TurnSystem (battlePanel);
		canvas.enabled = false;
		isBattle = false;
	}

	public void checkIfWinPlayer(){
		// Quiero hacer map.all y listo
		bool res = true;

		foreach (Entity enemy in enemyEntities) {
			res = res && enemy.isDie ();
		}

		if (res) {
			win ();
		}
	}

	public void checkIfDiePlayer(){
		bool res = true;

		foreach (Entity player in playerEntities) {
			res = res && player.isDie ();
		}

		if (res) {
			gameOver ();
		}
	}

	public void configCanvas () {
		battlePanel.loadBattle (playerEntities, enemyEntities);
	}

	public void newBattle(List<Entity> players, List<Entity> enemies) {
		isBattle = true;
		playerEntities = players;
		enemyEntities = enemies;
		configCanvas ();
		turnSystem.newCombat (new List<Entity>().Concat(players).Concat(enemies).ToList());
		nextPlayerTurn ();
	}

	public void nextPlayerTurn(){
		checkIfWinPlayer ();
		checkIfDiePlayer ();

		turnSystem.nextTurn ();
	}

	public void restartSystem(){

	}

	public void gameOver(){
		gameSystem.gameOver ();
		battlePanel.gameOver();
	}

	public void win(){
		gameSystem.win ();
		battlePanel.win();
	}

	public bool getIsBattle(){
		return isBattle;
	}

	public BattlePanel getBattlePanel(){
		return battlePanel;
	}

	public void finishBattle(){
		isBattle = false;
	}
}
