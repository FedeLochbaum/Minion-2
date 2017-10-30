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

	public void nextTurn(Entity entity){
		playerTurn.next (entity);
	}

	public void gameOver(){
	}

	public void win(){}
}
