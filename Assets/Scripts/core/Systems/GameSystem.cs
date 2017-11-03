﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSystem : MonoBehaviour {


	public Canvas battleCanvas;

	private int maximumAmountOfEnemies = 4;
	private BattleSystem battleSystem;
	private ActionSystem actionSystem;
	private List<BattleStrategy> strategies;
	private SoundSystem soundSystem;
	private LevelingSystem levelingSystem;
	private List<Entity> teamPlayer;
	private List<Entity> teamEnemy;

	void Start () {
		levelingSystem = new LevelingSystem ();
		battleSystem = new BattleSystem (this, battleCanvas);
		actionSystem = new ActionSystem (this);

		//teamPlayer = new List<Entity>(GameObject.FindObjectsOfType<Player> ());
		teamPlayer = new List<Entity>{new Aragorn(), new Kvothe(), new Netero(), new Tyrande() };

		strategies = new List<BattleStrategy>{ new EasyStrategy ()};
		soundSystem = gameObject.GetComponent<SoundSystem> ();
		soundSystem.playAmbientSound();
	}
		
	public void finishTurnPlayer(){
		battleSystem.nextPlayerTurn ();
	}

	public void gameOver(){
		battleSystem.GetComponent<BattlePanel> ().gameOver ();
		finishBattle ();
	}

	public void win(){
		battleSystem.GetComponent<BattlePanel> ().win();
		levelingSystem.gainExperience (teamPlayer, teamEnemy);
		finishBattle ();
	}

	public void finishBattle(){
		battleSystem.GetComponent<BattlePanel> ().finishBattle ();
		soundSystem.finishBattle ();
	}

	public void generateBattle(){
		teamEnemy = generateEnemies (Random.Range(1, maximumAmountOfEnemies));
		battleSystem.newBattle(teamPlayer, teamEnemy);
		soundSystem.startBattle();
	}

	public List<Entity> generateEnemies(int numberOfEnemies){
		BattleStrategy strategyOfMonsters = strategies [Random.Range (0, strategies.ToArray ().Length)];
		List<Entity> enemies = new List<Entity> ();
		for(int i = 1; i <= numberOfEnemies; ++i){
			// Es probable que cambie luego.
			// Luego sera necesario ponerle un sprite.
			// Darle tambien un nivel a los enemies y que a partir de esto tambien les cambie los stats.
			Entity enemy = new Enemy("Enemy " + i,teamPlayer, strategyOfMonsters);
			enemies.Add(enemy);
		}
		return enemies;
	}

	public ActionSystem getActionSystem(){
		return actionSystem;
	}

	public BattleSystem getBattleSystem(){
		return battleSystem;
	}
}
