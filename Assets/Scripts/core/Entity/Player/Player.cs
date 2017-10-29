using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Entity {

	protected List<Spell> magicSkills;
	protected SpecialSkill special;
	// Falta Inventario con Items..

	public Player (string name) : base(name) {
		magicSkills = new List<Spell> ();
		special = new SpecialSkill (stats, 0f, new List<Spell>());
	}

	public override void selectAction(){
		// Desplegar UI de seleccion.
		// La UI llamara a cualquiera de los metodos de abajo.
	}

	public void selectPhysicalAttackAction(Entity enemy){
		applyAction (new PhysicalAttackAction (this, new List<Entity>{enemy}));
	}

	public void selectRunAction(){
		applyAction (new RunAction ());
	}

	public void selectMagicalAction(int spellPosition, List<Entity> affectedEntities){
		applyAction (new MagicalAction(this, affectedEntities, magicSkills[spellPosition]));
	}
		
	public void selectSpecialAction(List<Entity> affectedEntities){
		applyAction (new MagicalAction (this, affectedEntities, special));
	}
		
	public void selectUseItem(Item item, List<Entity> affectedEntities){
		applyAction (new UseItemAction (this, affectedEntities, item));
	}

}
