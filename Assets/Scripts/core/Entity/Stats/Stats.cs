using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats : MonoBehaviour {

	private StatsCalculator calculator;

	// Stats principales
	private float str;
	private float agi;
	private float vit;
	private float inte;
	private float dex;
	private float luk;


	public Stats(){
		str = 25f;
		agi = 25f;
		vit  = 25f;
		inte = 25f;
		dex  = 25f;
		luk  = 25f;
		calculator = new StatsCalculator (this);
	}

	public float level(){
		// por ahora asi. Cuando implemente el Level se usara.
		return 1f;
	}

	public PhysicalDamage getPhysicalDamage (){
		return new PhysicalDamage (this, calculator.getMinPhysicalDamage(), calculator.getMaxPhysicalDamage());
	}

	public MagicalDamage getMagicalDamage (){
		return new MagicalDamage (this, calculator.getMinMagicalDamage(), calculator.getMaxMagicalDamage());
	}

	public void takeMagicalDamage(float finalDamage){
		calculator.takeMagicalDamage (finalDamage);
	}

	public void takePhysicalDamage(float finalDamage){
		calculator.takePhysicalDamage (finalDamage);
	}
		
	public void updateTurn(){
		calculator.updateEffects ();
	}

	public bool isDie (){
		return calculator.isDie();
	}

	public void reduceSp(float cost){
		calculator.reduceSp (cost);
	}

	public float actionSpeed(){
		return calculator.attackSpeed();
	}

	public void applyEffect(Effect effect){
		calculator.addEffect (effect);
	}

	public void removeEffect(Effect effect){
		calculator.removeEffect (effect);
	}

	// Getters
	public float getStr(){
		return str;
	}

	public float getAgi(){
		return agi;
	}
		
	public float getDex(){
		return dex;
	}
		
	public float getInt(){
		return inte;
	}
		
	public float getLuk(){
		return luk;
	}
		
	public float getVit(){
		return vit;
	}

	// Seters

	public void setStr(float str){
		this.str = str;
	}

	public void setAgi(float agi){
		this.agi = agi;
	}

	public void setDex(float dex){
		this.dex = dex;
	}

	public void setVit(float vit){
		this.vit = vit;
	}

	public void setLuk(float luk){
		this.luk = luk;
	}

	public void setInt(float inte){
		this.inte = inte;
	}
}
