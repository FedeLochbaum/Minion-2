using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattlePanel : MonoBehaviour {	

	private PlayerTurn playerTurn;
	private OptionView optionView;


	void Start () {
		playerTurn = gameObject.GetComponent<PlayerTurn> ();
		optionView = gameObject.GetComponent<OptionView> ();
	}

	public void loadBattle(List<Entity> players, List<Entity> enemies){
		gameObject.GetComponent<Canvas> ().enabled = true;
	
		//optionView.load (players);
		// faltaria cargar el responsable de mostrar los enemigos y los players
	}

	public void finishBattle(){
		gameObject.GetComponent<Canvas> ().enabled = false;
	}

	public void gameOver(){
	}

	public void win(){}

	public void selectAction(Player player) {
		print ("Player : " + player.getName ());
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
