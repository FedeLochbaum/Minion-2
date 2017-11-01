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

	public float getExperienceForLevel(Player player, Enemy enemy){
		return enemy.getExperience() * getPercentageOfAgain(player, enemy) * 1.5f;
	}

	public float getPercentageOfAgain(Player player, Enemy enemy){
		float playerLvl = player.getStats ().getLevel ().getLevel ();
		float enemyLvl = enemy.getStats ().getLevel ().getLevel ();
		float gap = enemyLvl - playerLvl;
		return calculatePercetageByGap (gap);
	}

	public float calculatePercetageByGap(float gap){
		switch (gap) {
		case 3:
			return 1.05f;
			break;
		case 4:
			return 1.1f;
			break;
		case 5:
			return 1.15f;
			break;
		case 6:
			return 1.2f;
			break;
		default:
			return 1f;
			break;
		}
	}
}
