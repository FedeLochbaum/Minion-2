using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseItemAction : AffectAction {
	
	private Item item;

	public UseItemAction(Item item){
		this.item = item;
	}

	public void apply (){
		affectedEntities.ForEach( entity => item.use(entity));
	}
}
