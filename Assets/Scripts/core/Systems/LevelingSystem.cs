using UnityEngine;
using System.Collections;
using System.Collections.Generic;



public class LevelingSystem {

	public void gainExperience(List<Entity> players, List<Entity> enemies){
		foreach (Entity player in players) {
			foreach (Entity enemy in enemies) {
				float experience = getExperienceForLevel(player, enemy) * enemies.Count;
				Debug.Log ("El player: " + player.getName() + " Obtuvo " + experience.ToString() + " de experiencia por parte de " + enemy.getName());
				player.getStats ().getLevel ().addExperience (experience);
			}	
		}
	}

	public float getExperienceForLevel(Entity player, Entity enemy){
		float exp = enemy.getExperience ();
		float percentageOfAgain = getPercentageOfAgain (player, enemy);
		return  1000 * percentageOfAgain * 1.5f;
	}

	public float getPercentageOfAgain(Entity player, Entity enemy){
		float playerLvl = player.getStats ().getLevel ().getLevel ();
		float enemyLvl = enemy.getStats ().getLevel ().getLevel ();
		float gap = enemyLvl - playerLvl;
		return calculatePercetageByGap (gap);
	}

	public float calculatePercetageByGap(float gap){
		float percetageOfGap = 0.1f * gap;
		return (gap > 0) ? 1 + percetageOfGap : 1 - percetageOfGap;			
	}
}
