using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Entity {

	private List<Spell> magicSkill;
	private SpecialSkill special;
	// Falta Inventario con Items..

	public Player () : base() {
		magicSkill = new List<Spell> ();
		special = new SpecialSkill (stats, 0f);
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
		applyAction (new MagicalAction(this, affectedEntities, magicSkill[spellPosition]));
	}
		
	public void selectSpecialAction(List<Entity> affectedEntities){
		applyAction (new MagicalAction (this, affectedEntities, special));
	}
		
	public void selectUseItem(Item item, List<Entity> affectedEntities){
		applyAction (new UseItemAction (this, affectedEntities, item));
	}

}
