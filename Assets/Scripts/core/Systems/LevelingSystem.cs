using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelingSystem {

	public void gainExperience(List<Entity> players, List<Entity> enemies){
		foreach (Entity player in players) {
			foreach (Entity enemy in enemies) {
				float experience = getExperienceForLevel(player, enemy) * enemies.Count;
				player.getStats ().getLevel ().addExperience (experience);
			}	
		}
	}

	public float getExperienceForLevel(Entity player, Entity enemy){
		return enemy.getExperience() * getPercentageOfAgain(player, enemy) * 1.5f;
	}

	public float getPercentageOfAgain(Entity player, Entity enemy){
		float playerLvl = player.getStats ().getLevel ().getLevel ();
		float enemyLvl = enemy.getStats ().getLevel ().getLevel ();
		float gap = enemyLvl - playerLvl;
		return calculatePercetageByGap (gap);
	}

	public float calculatePercetageByGap(float gap){
		return gap * 0.5f;
	}
}
