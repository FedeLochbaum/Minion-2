using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Entity {

	protected List<Spell> magicSkills;
	protected SpecialSkill special;
	private BattlePanel battlePanel; 
	// Falta Inventario con Items..

	public Player (string name) : base(name) {
		magicSkills = new List<Spell> ();
		special = new SpecialSkill (stats, 0f, new List<Spell>(), "");
		battlePanel = gameSystem.GetComponent<BattlePanel>();
	}

	public override void myTurn(){
		battlePanel.selectAction(this);
	}

	public void selectPhysicalAttackAction(Entity enemy){
		applyAction (new PhysicalAttackAction (this, new List<Entity>{enemy}));
		finishTurn ();
	}

	public void selectRunAction(){
		applyAction (new RunAction ());
	}

	public void selectMagicalAction(int spellPosition, List<Entity> affectedEntities){
		applyAction (new MagicalAction(this, affectedEntities, magicSkills[spellPosition]));
		finishTurn ();
	}
		
	public void selectSpecialAction(List<Entity> affectedEntities){
		applyAction (new MagicalAction (this, affectedEntities, special));
		finishTurn ();
	}
		
	public void selectUseItem(Item item, List<Entity> affectedEntities){
		applyAction (new UseItemAction (this, affectedEntities, item));
		finishTurn ();
	}

}
