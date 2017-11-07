using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSystem : MonoBehaviour {

	public Sprite kvotheSprite;
	public Sprite neteroSprite;
	public Sprite tyrandeSprite;
	public Sprite aragornSprite;

	public List<Sprite> randomSprites;
	public Canvas battleCanvas;

	private int maximumAmountOfEnemies = 4;
	private BattleSystem battleSystem;
	private ActionSystem actionSystem;
	private List<BattleStrategy> strategies;
	private SoundSystem soundSystem;
	private LevelingSystem levelingSystem;
	private List<Entity> teamPlayer;
	private List<Entity> teamEnemy;

	void Start () {
		levelingSystem = new LevelingSystem ();
		battleSystem = new BattleSystem (this, battleCanvas);
		actionSystem = new ActionSystem (this);

		Player aragorn = new Aragorn ();
		Player kvothe = new Kvothe ();
		Player netero = new Netero ();
		Player tyrande = new Tyrande ();

		aragorn.sprite = aragornSprite;
		kvothe.sprite = kvotheSprite;
		netero.sprite = neteroSprite;
		tyrande.sprite = tyrandeSprite;

		teamPlayer = new List<Entity>{aragorn, kvothe, netero, tyrande};

		strategies = new List<BattleStrategy>{ new EasyStrategy ()};
		soundSystem = gameObject.GetComponent<SoundSystem> ();
		soundSystem.playAmbientSound();
	}
		
	public void finishTurnPlayer(){
		battleSystem.nextPlayerTurn ();
	}

	public void gameOver() {
		battleSystem.getBattlePanel().gameOver ();
		finishBattle ();
	}

	public void win(){
		battleSystem.getBattlePanel().win();
		levelingSystem.gainExperience (teamPlayer, teamEnemy);
		finishBattle ();
	}

	public void finishBattle(){
		battleSystem.getBattlePanel().finishBattle ();
		soundSystem.finishBattle ();
		battleSystem.finishBattle ();
	}

	public void generateBattle(){
		teamEnemy = generateEnemies (Random.Range(1, maximumAmountOfEnemies));
		battleSystem.newBattle(teamPlayer, teamEnemy);
		soundSystem.startBattle();
	}

	public List<Entity> generateEnemies(int numberOfEnemies){
		BattleStrategy strategyOfMonsters = strategies [Random.Range (0, strategies.ToArray ().Length)];
		List<Entity> enemies = new List<Entity> ();
		for(int i = 1; i <= numberOfEnemies; ++i){

			Entity enemy = new Enemy("Enemy " + i,teamPlayer, strategyOfMonsters);

			enemy.getStats().getLevel().addExperience(Random.Range (1, maxLevelPlayer ()) * 1000);

			enemy.sprite = randomSprites [Random.Range (0, randomSprites.Count - 1)];

			enemies.Add(enemy);
		}
		return enemies;
	}

	public ActionSystem getActionSystem(){
		return actionSystem;
	}

	public BattleSystem getBattleSystem(){
		return battleSystem;
	}

	public float maxLevelPlayer (){
		float maxLevel = 1;

		foreach (Entity player in teamPlayer) {
			float levelPlayer = player.getStats ().getLevel ().getLevel ();
			maxLevel = (levelPlayer >= maxLevel) ? levelPlayer : maxLevel;
		}

		return maxLevel;
	}
}
