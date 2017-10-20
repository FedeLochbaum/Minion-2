using UnityEngine;
using System.Collections.Generic;

public class TurnSystem : MonoBehaviour {

	Queue<Entity> entities;
		
	public void newCombat(Entity[] entitiesArray){
		entities = new Queue<Entity>(sortEntities (entitiesArray));
	}

	public void nextTurn(){
		Entity first = entities.Dequeue ();
		first.myTurn ();
		entities.Enqueue (first);
	}

	public Entity[] sortEntities(Entity[] entities){
		return (entities.Sort ((IComparer<Entity>)new EntityCompare ()));
	}

	public void removeEntity(Entity entity){
		List<Entity> entitiesAux = new List<Entity> (entities.ToArray ());
		entitiesAux.Remove (entity);
		entitiesAux.ToArray ();
		entities = new Queue<Entity>(entitiesAux);
	}


}
	
