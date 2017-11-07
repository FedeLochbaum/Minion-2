using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Entity {

	protected List<Spell> magicSkills;
	protected SpecialSkill special;
	protected BattlePanel battlePanel; 

	public Player (string name) : base(name) {
		magicSkills = new List<Spell> ();
		special = new SpecialSkill (stats, 0f, new List<Spell>(), "");
		battlePanel = gameSystem.battleCanvas.GetComponent<BattlePanel>();
	}

	public override void myTurn(){
		battlePanel.selectAction(this);
	}

	public void selectPhysicalAttackAction(Entity enemy){
		applyAction (new PhysicalAttackAction (this, new List<Entity>{enemy}));
		finishTurn ();
	}

	public void selectRunAction(){
		applyAction (new FleeAction ());
		finishTurn ();
	}

	public void selectMagicalAction(Spell spellSelected, List<Entity> affectedEntities){
		applyAction (new MagicalAction(this, affectedEntities, spellSelected));
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

	public List<Spell> getMagicalSkills(){
		return magicSkills;
	}

	public Spell getSpecialSkill(){
		return special;
	}

}
