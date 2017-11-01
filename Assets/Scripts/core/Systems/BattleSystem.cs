using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

public class BattleSystem : MonoBehaviour {

	private TurnSystem turnSystem;
	private BattlePanel battlePanel;
	private List<Entity> playerEntities;
	private List<Entity> enemyEntities;

	private bool isCombat;
	private GameSystem gameSystem;

	public BattleSystem(GameSystem gameSystem, Canvas canvas){
		this.gameSystem = gameSystem;
		battlePanel = canvas.GetComponent<BattlePanel>();
		turnSystem = new TurnSystem (battlePanel);
		canvas.enabled = false;
		isCombat = false;
	}

	void Update () {
		
		if (isCombat) {
			checkIfAnyEntityDie ();

			checkIfWinPlayer ();

			checkIfDiePlayer ();
		}
	}

	public void checkIfAnyEntityDie(){
		foreach (Entity entity in playerEntities) {
			if (entity.isDie ()) {
				playerEntities.Remove (entity);
				turnSystem.removeEntity (entity);
			}
		}

		foreach (Entity entity in enemyEntities) {
			if (entity.isDie ()) {
				enemyEntities.Remove (entity);
				turnSystem.removeEntity (entity);
			}
		}
	}

	public void checkIfWinPlayer(){
		if(enemyEntities.Count == 0)
			win ();
	}

	public void checkIfDiePlayer(){
		if(playerEntities.Count == 0)
			gameOver ();
	}

	public void configCanvas ()
	{
		battlePanel.loadBattle (playerEntities, enemyEntities);
	}

	public void newBattle(List<Entity> players,List<Entity> enemies) {
		playerEntities = players;
		enemyEntities = enemies;
		configCanvas ();
		turnSystem.newCombat (new List<Entity>().Concat(players).Concat(enemies).ToList());
		isCombat = true;
	}

	public void finishTurn(){
		turnSystem.nextTurn ();
	}

	public void restartSystem(){

	}

	public void nextPlayerTurn(){
		turnSystem.nextTurn ();
	}

	public void gameOver(){
		gameSystem.gameOver ();
		battlePanel.gameOver();
	}

	public void win(){
		gameSystem.win ();
		battlePanel.win();
	}
}
