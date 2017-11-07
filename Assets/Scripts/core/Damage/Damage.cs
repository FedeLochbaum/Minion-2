using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour {

	private float minDamage;
	private float maxDamage;
	protected Stats playerStats;

	public Damage(Stats stats, float minDamage, float maxDamage){
		playerStats = stats;
		this.minDamage = minDamage;
		this.maxDamage = maxDamage;
	}

	public float generateDamage () {
		//0 - 9 Excelent Damage
		//10 - 29 Critical Damage
		// 30 - 99 Random Damage  
		// Tal vez deberia cambiar para que dependa del player

		float randomProbably = Random.Range(0, 99);
		if (randomProbably < 9) {
			return (Random.Range (minDamage, maxDamage) * 1.5f);
		} else if (randomProbably < 29) {
			return maxDamage;
		}

		return Random.Range (minDamage, maxDamage);
	}
}
