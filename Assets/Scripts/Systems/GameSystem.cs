using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSystem : MonoBehaviour {
	private int maximumAmountOfEnemies = 4;
	private BattleSystem battleSystem;
	private ActionSystem actionSystem;
	private List<Entity> teamPlayer;
	private List<BattleStrategy> strategies;
	private float battleProbability = 40f;


	void Start () {
		battleSystem = new BattleSystem (this);
		actionSystem = new ActionSystem (this);
		teamPlayer = new List<Entity>(GameObject.FindObjectsOfType<Player> ());
		strategies = new List<BattleStrategy>{ new EasyStrategy (), new NormalStrategy () };
	}
		
	public void load(){
		// Es llamado cuando el player da un paso.
		if(Random.Range(1, 100) <= battleProbability){
			generateBattle ();
		}
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
		generateEnemies (Random.Range(1, maximumAmountOfEnemies));
		battleSystem.newBattle();
	}

	public void generateEnemies(int numberOfEnemies){
		BattleStrategy strategyOfMonsters = strategies [Random.Range (0, strategies.ToArray ().Length)];
		for(int i = 1; i <= numberOfEnemies; ++i){
			// Es probable que cambie luego.
			// Luego sera necesario ponerle un sprite y eso.
			new Enemy(teamPlayer, strategyOfMonsters);
		}
	}
}
