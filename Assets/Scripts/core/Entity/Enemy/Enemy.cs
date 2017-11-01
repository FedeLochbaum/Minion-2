﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Entity {

	private List<Entity> battlePlayers;
	private BattleStrategy strategy;

	public Enemy (string name, List<Entity> battlePlayers, BattleStrategy strategy) : base(name) {
		this.battlePlayers = battlePlayers;
		this.strategy = strategy;
	}

	public override void selectAction(){
		applyAction (strategy.getBestAction(this, battlePlayers));
	}

	public float getExperience(){
		return strategy.getExperience ();
	}
}
