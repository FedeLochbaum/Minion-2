using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSystem : MonoBehaviour {
	private BattleSystem battleSystem;
	private ActionSystem actionSystem;
	private List<Player> teamPlayer;

	void Start () {
		battleSystem = new BattleSystem (this);
		actionSystem = new ActionSystem (this);
		teamPlayer = new List<Player>(GameObject.FindObjectsOfType<Player> ());
	}

	void Update () {
	}

	public void finishTurnPlayer(){
		battleSystem.nextPlayerTurn ();
	}

	public void gameOver(){}

	public void win(){}

	public void finishBattle(){
		// cuando llaman a run
	}

	public void generateBattle(){
		generateEnemies ();
		battleSystem.newBattle();
	}

	public void generateEnemies(){
		// generar enemigos de manera aleatoria
	}
}
