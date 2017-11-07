using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats : MonoBehaviour {

	private StatsCalculator calculator;

	public float str;
	public float agi;
	public float vit;
	public float inte;
	public float dex;
	public float luk;

	public Level level;


	public Stats() {
		str = 25f;
		agi = 25f;
		vit  = 25f;
		inte = 25f;
		dex  = 25f;
		luk  = 25f;
		calculator = new StatsCalculator (this);
		level = new Level (this);
	}

	public Level getLevel(){
		return level;
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

	public int getSp(){
		return (int) calculator.getSp ();
	}

	public int getHp(){
		return (int) calculator.getHp ();
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

	public void levelUp(){
		setAgi (getAgi() + (level.getLevel() / 2));
		setDex (getDex() + (level.getLevel() / 1.5f));
		setInt (getInt() + (level.getLevel() / 1.2f));
		setLuk (getLuk() + (level.getLevel() / 1.9f));
		setStr (getStr() + (level.getLevel() / 1.1f));
		setVit (getVit() + (level.getLevel() / 1.3f));

		calculator.levelUp ();
	}

	public float getMaxHp(){
		return calculator.getMaxHp ();
	}

	public float getMaxSp(){
		return calculator.getMaxSp ();
	}
}
