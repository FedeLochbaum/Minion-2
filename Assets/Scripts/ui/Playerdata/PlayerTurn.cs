using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerTurn : MonoBehaviour {

	private Player playerTurn;

	void Start () {

	}

	void playerHealthBar () {
		GameObject healthBarObj = GameObject.FindGameObjectWithTag ("playerTurnHealth");

		Text text = healthBarObj.GetComponentInChildren<Text>();
		Image uiImageHpPlayer = healthBarObj.GetComponentInChildren<Image> ();

		text.text = playerTurn.getStats().getHp().ToString() + "/ " + playerTurn.getStats().getMaxHp().ToString();
		uiImageHpPlayer.fillAmount = playerTurn.getStats().getHp() / playerTurn.getStats().getMaxHp();
	}

	void playerEnergyBar () {
		GameObject manaBarObj = GameObject.FindGameObjectWithTag ("playerTurnMana");

		Text text = manaBarObj.GetComponentInChildren<Text>();
		Image uiImageSpPlayer = manaBarObj.GetComponentInChildren<Image> ();

		text.text = playerTurn.getStats().getSp().ToString() + "/ " + playerTurn.getStats().getMaxSp().ToString();
		uiImageSpPlayer.fillAmount = playerTurn.getStats().getSp() / playerTurn.getStats().getMaxSp();
	}

	public void turnOf(Player entity){
		playerTurn = entity;

		playerHealthBar();
		playerEnergyBar();
	}
}
