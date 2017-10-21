using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour {

	private RangeInt rangeDamage;
	private TreeStats playerStats;

	public Damage(TreeStats stats, RangeInt damage){
		playerStats = stats;
		rangeDamage = damage;
	}

	public void applyDamage(Entity entity){
		float finalDamage = generateDamage ();
		entity.getStats().takeDamage (finalDamage);
	}

	public float generateDamage () {
		//0 - 9 Excelent Damage
		//10 - 29 Critical Damage
		// 30 - 99 Random Damage  
		// Luego deberia cambiar para que dependa del player

		float randomProbably = Random.Range(0, 99);
		if (randomProbably < 10) {
			return (Random.Range (rangeDamage) * 1.5f);
		} else if (randomProbably < 30) {
			return rangeDamage.end;
		}

		return Random.Range (rangeDamage);
	}
}
