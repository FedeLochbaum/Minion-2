using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthBar : MonoBehaviour {

	public void load(Entity entity){
		gameObject.GetComponent<GUIText>().text = entity.getStats().getHp().ToString();
		// falta utilizar el fillAmount
		gameObject.GetComponent<Image>().fillAmount = entity.getStats().getHp() / 100f;
	}
}
