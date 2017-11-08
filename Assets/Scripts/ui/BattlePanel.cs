using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattlePanel : MonoBehaviour {	

	public GameObject playerTurnObject;
	public GameObject optionViewObject;

	public GameObject gameOverObject;

	private PlayerTurn playerTurn;
	private OptionView optionView;


	void Start () {
		playerTurn = playerTurnObject.GetComponent<PlayerTurn> ();
		optionView = optionViewObject.GetComponent<OptionView> ();
	}

	public void loadBattle(List<Entity> players, List<Entity> enemies){
		gameObject.GetComponent<Canvas> ().enabled = true;
		optionView.load (players, enemies);
	}

	public void finishBattle(){
		gameObject.GetComponent<Canvas> ().enabled = false;
	}

	public void gameOver(){
		gameOverObject.SetActive (true);
		optionView.gameOver ();
	}

	public void win(){
		finishBattle ();
	}

	public void selectAction(Player player) {
		playerTurn.turnOf (player);
		optionView.newTurnForSelectAction (player);
		optionView.reload ();
	}

	public void Wait(float seconds){
		StartCoroutine(wait(seconds));
	}
	IEnumerator wait(float time){
		yield return new WaitForSeconds(time);
	}
}
