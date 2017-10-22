using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Entity {

	private List<Entity> battlePlayers;
	private BattleStrategy strategy;

	// Como el Game System es el que lo crea le puede pasar a los jugadores(no los de game System, sino el de battle system).
	public Enemy (List<Entity> battlePlayers, BattleStrategy strategy) : base() {
		this.battlePlayers = battlePlayers;
		this.strategy = strategy;
	}

	public override void selectAction(){
		applyAction (strategy.getBestAction(this, battlePlayers));
	}
}
