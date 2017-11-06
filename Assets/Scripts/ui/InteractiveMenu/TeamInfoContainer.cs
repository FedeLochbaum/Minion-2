using UnityEngine.UI;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;



public class TeamInfoContainer : MonoBehaviour {

	GameObject[] playersInfo;
	GameObject[] enemiesInfo;

	void Start () {
		playersInfo = GameObject.FindGameObjectsWithTag("playerInfo");
		enemiesInfo = GameObject.FindGameObjectsWithTag("enemyInfo");
	}

	public void loadPlayers(List<Entity> players) {
		for( int i = 0; i < players.Count; ++i ) {
			GameObject playerInfo = playersInfo [i];
		
			playerInfo.GetComponent<ListController> ().entity = players[i];

			Text[] texts = playerInfo.GetComponentsInChildren<Text>();
	
			texts[0].text = players[i].getStats().getHp().ToString() + "/ " + players[i].getStats().getMaxHp().ToString();
			texts[1].text = players[i].getName().ToString();

			Image uiImageHpPlayer = playerInfo.GetComponentInChildren<Image> ();
			uiImageHpPlayer.fillAmount = players[i].getStats().getHp() / players[i].getStats().getMaxHp();
		}
	}

	public void loadEnemies(List<Entity> enemies) {
		foreach (GameObject go in enemiesInfo) {
			go.SetActive (true);
		}
			
		for( int i = 0; i < enemies.Count; ++i ) {
			GameObject enemyInfo = enemiesInfo [i];



			enemyInfo.GetComponent<ListController> ().entity = enemies[i];

			enemyInfo.GetComponent<ListController> ().activeSprite ();

			Text[] texts = enemyInfo.GetComponentsInChildren<Text>();

			texts[0].text = enemies[i].getStats().getHp().ToString() + "/ " + enemies[i].getStats().getMaxHp().ToString();
			texts[1].text = enemies[i].getName().ToString();

			Image uiImageHpPlayer = enemyInfo.GetComponentInChildren<Image> ();
			uiImageHpPlayer.fillAmount = enemies[i].getStats().getHp() / enemies[i].getStats().getMaxHp();
		}
			

		for(int i = enemies.Count; i < enemiesInfo.Length; ++i) {
			GameObject enemyInfo = enemiesInfo [i];
			enemyInfo.SetActive (false);
		}
	}
}
