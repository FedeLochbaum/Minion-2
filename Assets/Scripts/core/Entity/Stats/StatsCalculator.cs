using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatsCalculator {

	private Stats stats;
	private StateCalculator stateCalculator;
	private OffensiveCalculator offensiveCalculator;
	private DefensiveCalculator defensiveCalculator;


	public StatsCalculator(Stats stats) {
		this.stats = stats;
		stateCalculator = new StateCalculator(stats);
		offensiveCalculator = new OffensiveCalculator(stats);
		defensiveCalculator = new DefensiveCalculator (stats);
	}

	public float getMinPhysicalDamage(){
		return offensiveCalculator.getMinPhysicalDamage ();
	}

	public float getMaxPhysicalDamage(){
		return offensiveCalculator.getMaxPhysicalDamage();
	}

	public float getMinMagicalDamage(){
		return offensiveCalculator.getMinMagicalDamage ();
	}

	public float getMaxMagicalDamage(){
		return offensiveCalculator.getMaxMagicalDamage ();
	}

	public bool isDie(){
		return stateCalculator.isDie ();
	}

	public float attackSpeed(){
		return offensiveCalculator.attackSpeed ();
	}

	public void takeMagicalDamage(float finalDamage){
		stateCalculator.takeDamage (defensiveCalculator.reduceMagicalDamage (finalDamage));
	}

	public void takePhysicalDamage(float finalDamage){
		stateCalculator.takeDamage (defensiveCalculator.reducePhysicalDamage (finalDamage));
	}

	public void reduceSp(float cost){
		stateCalculator.reduceSp (cost);
	}

	public float getSp(){
		return stateCalculator.getSp ();
	}

	public float getHp(){
		return stateCalculator.getHp ();
	}

	public void addEffect(Effect effect){
		stateCalculator.addEffect (effect);
		offensiveCalculator.addEffect(effect);
		defensiveCalculator.addEffect (effect);
	}

	public void removeEffect(Effect effect){
		stateCalculator.removeEffect (effect);
		offensiveCalculator.removeEffect(effect);
		defensiveCalculator.removeEffect (effect);
	}

	public void updateEffects(){
		stateCalculator.update ();
		offensiveCalculator.update();
		defensiveCalculator.update();
	}

}
