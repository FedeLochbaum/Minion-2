using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerEnergyBar : MonoBehaviour {

	public void load(Entity entity){
		gameObject.GetComponent<GUIText>().text = entity.getStats().getSp().ToString();
		// falta utilizar el fillAmount
		gameObject.GetComponent<Image>().fillAmount = entity.getStats().getSp() / 100f;
	}
}
