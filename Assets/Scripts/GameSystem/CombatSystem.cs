using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatSystem : MonoBehaviour {

	private TurnSystem turnSystem;

	private List<Entity> actualEntities;

	private bool isCombat;

	void Start () {
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
		List<Enemy> enemyEntities = actualEntities.FindAll (entity => entity.tag == "enemy");
		if(enemyEntities.Count == 0){
			win ();
			restartSystem ();
		}

	}

	public void checkIfDiePlayer(){
		// el filter podria cambiar
		List<Player> playerEntities = actualEntities.FindAll (entity => entity.tag == "player");
		if(playerEntities.Count == 0){
			gameOver ();
			restartSystem ();
		}
	}

	public void newCombat(){
		actualEntities = GameObject.FindObjectsOfType ((typeof(Entity)));
		isCombat = true;
		turnSystem.newCombat (actualEntities);
	}

	public void finishTurn(){
		turnSystem.nextTurn ();
	}

	public void restartSystem(){

	}

	public void gameOver(){
	}

	public void win(){}
}
