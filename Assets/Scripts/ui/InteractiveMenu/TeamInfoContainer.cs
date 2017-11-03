using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TeamInfoContainer : MonoBehaviour {

	public void loadPlayers(List<Entity> players) {
		GameObject[] playersInfo = GameObject.FindGameObjectsWithTag("playerInfo");

		for( int i = 0; i < players.Count; ++i ) {
			GameObject playerInfo = playersInfo [i];
			playerInfo.GetComponent<Text>().text = players[i].getName().ToString();
			//playerInfo.GetComponent<Image>().fillAmount = players[i].getStats().getHp() / 100f;
		}
	}

	public void loadEnemies(List<Entity> enemies) {
		GameObject[] playersInfo = GameObject.FindGameObjectsWithTag("enemyInfo");

		for( int i = 0; i < enemies.Count; ++i ) {
			GameObject enemyInfo = playersInfo [i];
			enemyInfo.GetComponent<Text>().text = enemies[i].getName().ToString();
			enemyInfo.GetComponent<Image>().fillAmount = enemies[i].getStats().getHp() / 100f;
		}
	}
}
