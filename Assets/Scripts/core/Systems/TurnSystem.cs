﻿using UnityEngine;
using System.Collections.Generic;

public class TurnSystem : MonoBehaviour {

	private BattlePanel battlePanel;

	public TurnSystem(BattlePanel battlePanel) {
		this.battlePanel = battlePanel;
	}

	Queue<Entity> entities;
	// Aun falta hacer el pasaje de turnos mas inteligente. Deberia ser algo asi como una carrrera por el turno.
	public void newCombat(List<Entity> entitiesArray){
		entities = new Queue<Entity>(sortEntities (entitiesArray));
	}

	public void nextTurn(){
		Entity first = entities.Dequeue ();
		battlePanel.nextTurn (first);
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
	
