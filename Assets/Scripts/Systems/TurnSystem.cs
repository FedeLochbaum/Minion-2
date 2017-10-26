using UnityEngine;
using System.Collections.Generic;

public class TurnSystem : MonoBehaviour {

	Queue<Entity> entities;
		
	public void newCombat(List<Entity> entitiesArray){
		entities = new Queue<Entity>(sortEntities (entitiesArray));
	}

	public void nextTurn(){
		Entity first = entities.Dequeue ();
		first.myTurn ();
		entities.Enqueue (first);
	}

	public List<Entity> sortEntities(List<Entity> entities){
		// Si.. no entiendo como pueden conformarse con esto.
		entities.Sort ((new EntityCompare ()));
		entities.Reverse ();
		return entities;
	}

	public void removeEntity(Entity entity){
		List<Entity> entitiesAux = new List<Entity> (entities.ToArray ());
		entitiesAux.Remove (entity);
		entitiesAux.ToArray ();
		entities = new Queue<Entity>(entitiesAux);
	}


}
	
