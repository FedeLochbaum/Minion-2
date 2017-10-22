using UnityEngine;
using System.Collections.Generic;

public class BattleSystem : MonoBehaviour {

	private TurnSystem turnSystem;

	private List<Entity> actualEntities;

	private bool isCombat;
	private GameSystem gameSystem;

	public BattleSystem(GameSystem gameSystem){
		this.gameSystem = gameSystem;
		turnSystem = new TurnSystem ();
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
		foreach (Entity entity in actualEntities) {
			if (entity.isDie ()) {
				actualEntities.Remove (entity);
				turnSystem.removeEntity (entity);
			}
		}
	}

	public void checkIfWinPlayer(){
		// el filter podria cambiar
		List<Entity> enemyEntities = actualEntities.FindAll (entity => entity.tag == "enemy");
		if(enemyEntities.Count == 0)
			win ();
	}

	public void checkIfDiePlayer(){
		// el filter podria cambiar
		List<Entity> playerEntities = actualEntities.FindAll (entity => entity.tag == "player");
		if(playerEntities.Count == 0)
			gameOver ();
	}

	public void newBattle(){
		actualEntities = new List<Entity>(GameObject.FindObjectsOfType<Entity>());
		turnSystem.newCombat (actualEntities);
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
	}

	public void win(){
		gameSystem.win ();
	}
}
