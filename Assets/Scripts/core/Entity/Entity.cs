using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Entity : MonoBehaviour {
	
	protected List<Spell> magicSkills;
	protected string entityName;
	public Stats stats; 
	protected ActionSystem actionSystem;
	protected GameSystem gameSystem;

	public Sprite sprite;

	public Entity (string name) {
		entityName = name;
		stats = new Stats (this);
		gameSystem = GameObject.FindObjectOfType<GameSystem> ();
		actionSystem = gameSystem.getActionSystem();
	}

	public string getName(){
		return entityName;
	}

	public bool isDie (){
		return stats.isDie ();
	}

	public float actionSpeed ()
	{
		return stats.actionSpeed ();
	}

	public abstract void myTurn ();

	public void finishTurn(){
		stats.updateTurn ();
		gameSystem.finishTurnPlayer ();
	}

	public void applyAction (Action action){		
		actionSystem.ApplyAction (action);
	}

	public Stats getStats(){
		return stats;
	}

	public float getExperience(){
		return 1f;
	}

	public Sprite getSprite() {
		return sprite;
	}

	public void addExperience(float exp){
		stats.getLevel ().addExperience (exp);
	}

	public List<Spell> getMagicalSkills(){
		return magicSkills;
	}

	public bool canUseSpell(Spell spell){
		return stats.getSp () >= spell.getCost ();
	}
}
