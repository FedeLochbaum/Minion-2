using UnityEngine;
using System.Collections.Generic;

public class TurnSystem : MonoBehaviour {

	private BattlePanel battlePanel;
	private Queue<Entity> entities;

	public TurnSystem(BattlePanel battlePanel) {
		this.battlePanel = battlePanel;
	}

	// Aun falta hacer el pasaje de turnos mas inteligente. Deberia ser algo asi como una carrrera por el turno.
	public void newCombat(List<Entity> entitiesArray){
		entities = new Queue<Entity>(sortEntities (entitiesArray));
	}

	public void nextTurn(){
		Entity first = entities.Dequeue ();
		if (!first.isDie ()) {
			entities.Enqueue (first);
			first.myTurn ();
		} else {
			// removeEntity (first); ya lo hace cuando hace dequeue
			nextTurn ();
		}
	}

	public List<Entity> sortEntities(List<Entity> entities){
		entities.Sort ((new EntityCompare ()));
		entities.Reverse ();
		return entities;
	}

	public void removeEntity(Entity entity) {
		List<Entity> entitiesAux = new List<Entity> (entities.ToArray ());
		entitiesAux.Remove (entity);
		entitiesAux.ToArray ();
		entities = new Queue<Entity>(entitiesAux);
	}


}
	
