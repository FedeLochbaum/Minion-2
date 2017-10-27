using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseItemAction : AffectAction {
	
	private Item item;

	public UseItemAction(Entity creator, List<Entity> affectedEntities, Item item) : base(creator, affectedEntities){
		this.item = item;
	}

	public override void apply (){
		affectedEntities.ForEach( entity => item.use(entity));
	}
}
