using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelingSystem {

	public void gainExperience(List<Entity> players, List<Entity> enemies){
		foreach (Entity player in players) {
			foreach (Entity enemy in enemies) {
				float experience = getExperienceForLevel(enemy.getStats().getLevel().getLevel()) * enemies.Count;
				player.getStats ().getLevel ().addExperience (experience);
			}	
		}
	}

	public float getExperienceForLevel(float enemyLevel){
		return enemyLevel * 1000 * 1.5f;
	}
}
