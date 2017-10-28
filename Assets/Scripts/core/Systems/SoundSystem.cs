using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundSystem : MonoBehaviour {

	public AudioClip battleSound;
	public AudioClip ambientSound;

	private AudioSource audioS;

	void Start () {
		audioS = gameObject.GetComponent<AudioSource> ();
	}

	public void startBattle(){
		audioS.Stop ();
		audioS.clip = battleSound;
		audioS.Play ();
	}

	public void finishBattle(){
		audioS.Stop ();
		audioS.clip = ambientSound;
		audioS.Play ();
	}

	public void playAmbientSound(){
		audioS.clip = ambientSound;
		audioS.Play ();
	}

}

