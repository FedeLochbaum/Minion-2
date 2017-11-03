using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattlePanel : MonoBehaviour {	

	public GameObject playerTurnObject;
	public GameObject optionViewObject;


	private PlayerTurn playerTurn;
	private OptionView optionView;

	void Start () {
		playerTurn = playerTurnObject.GetComponent<PlayerTurn> ();
		optionView = optionViewObject.GetComponent<OptionView> ();
	}

	public void loadBattle(List<Entity> players, List<Entity> enemies){
		gameObject.GetComponent<Canvas> ().enabled = true;

		optionView.load (players, enemies);
		// faltaria cargar el responsable de mostrar los enemigos y los players
	}

	public void finishBattle(){
		gameObject.GetComponent<Canvas> ().enabled = false;
	}

	public void gameOver(){
	}

	public void win(){
		
	}

	public void selectAction(Player player) {
		playerTurn.turnOf (player);
		// En algun momento cuando el usuario seleccione su accion, debera llamar a algun SelectAction del Player
	}

	public void Wait(float seconds){
		StartCoroutine(wait(seconds));
	}
	IEnumerator wait(float time){
		yield return new WaitForSeconds(time);
	}
}
