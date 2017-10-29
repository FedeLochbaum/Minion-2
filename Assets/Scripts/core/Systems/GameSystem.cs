using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSystem : MonoBehaviour {
	private int maximumAmountOfEnemies = 4;
	private BattleSystem battleSystem;
	private ActionSystem actionSystem;
	private List<Entity> teamPlayer;
	private List<BattleStrategy> strategies;
	public float battleProbability = 10f;
	private SoundSystem soundSystem;

	void Start () {
		battleSystem = new BattleSystem (this);
		actionSystem = new ActionSystem (this);
		teamPlayer = new List<Entity>(GameObject.FindObjectsOfType<Player> ());
		strategies = new List<BattleStrategy>{ new EasyStrategy (), new NormalStrategy () };
		soundSystem = gameObject.GetComponent<SoundSystem> ();
		soundSystem.playAmbientSound();
	}
		
	public void load(){
		if(Random.Range(1, 100) <= battleProbability){
			generateBattle ();
		}
	}
		
	public void finishTurnPlayer(){
		battleSystem.nextPlayerTurn ();
	}

	public void gameOver(){}

	public void win(){}

	public void finishBattle(){
		// cuando llaman a run

		soundSystem.finishBattle ();
	}

	public void generateBattle(){
		generateEnemies (Random.Range(1, maximumAmountOfEnemies));
		battleSystem.newBattle();
		soundSystem.startBattle();
	}

	public void generateEnemies(int numberOfEnemies){
		BattleStrategy strategyOfMonsters = strategies [Random.Range (0, strategies.ToArray ().Length)];
		for(int i = 1; i <= numberOfEnemies; ++i){
			// Es probable que cambie luego.
			// Luego sera necesario ponerle un sprite y eso.
			new Enemy("Enemy " + i,teamPlayer, strategyOfMonsters);
		}
	}
}
