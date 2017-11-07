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

			playerInfo.GetComponent<ListController> ().activeSprite ();

			Text[] texts = playerInfo.GetComponentsInChildren<Text>();

			float hp = players [i].getStats ().getHp ();
			float maxHp = players [i].getStats ().getMaxHp ();
	
			texts[0].text = hp.ToString() + "/ " + maxHp.ToString();
		
			texts[1].text = players[i].getName().ToString();

			Image uiImageHpPlayer = playerInfo.GetComponentInChildren<Image> ();

			uiImageHpPlayer.fillAmount = hp / maxHp;
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

			float hp = enemies [i].getStats ().getHp ();
			float maxHp = enemies [i].getStats ().getMaxHp ();

			texts[0].text = hp.ToString() + "/ " + maxHp.ToString();
			texts[1].text = enemies[i].getName().ToString();

			Image uiImageHpPlayer = enemyInfo.GetComponentInChildren<Image> ();

			uiImageHpPlayer.fillAmount = hp / maxHp;
		}
			

		for(int i = enemies.Count; i < enemiesInfo.Length; ++i) {
			GameObject enemyInfo = enemiesInfo [i];
			enemyInfo.SetActive (false);
		}
	}
}
