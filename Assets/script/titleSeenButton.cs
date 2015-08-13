using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections;

public class titleSeenButton : MonoBehaviour {
	//file create
	const String NAME = "NAME";
	const String WEIGHT = "WEIGHT";
	const String POWER = "POWER";
	const String STAMINA = "STAMINA";
	const String MONEY = "MONEY";

	//変数宣言
	int weight;
	int power;
	int stamina;
	int money;

	void Start(){
		SoundManager.Instance.PlayBGM(2);
	}

	//はじめからがおされたら
	public void clickStartButton(){
		SoundManager.Instance.PlaySE(6);
		SoundManager.Instance.StopBGM();
		//最初にゲームを開始する際に初期値を設定
		weight =70;
		SaveWeight(weight);
		power = 30;
		SavePower(power);
		stamina = 100;
		SaveStamina(stamina);
		money = 1000;
		SaveMoney(money);
		Application.LoadLevel ("gameMainSeen");
	}

	//コンティニューボタンが押されたら
	public void clickContinueButton(){
		SoundManager.Instance.PlaySE(6);
		SoundManager.Instance.StopBGM();
		Application.LoadLevel ("gameMainSeen");
	}

	//save
	void SaveWeight(int weight){
		PlayerPrefs.SetInt(WEIGHT, weight);
		PlayerPrefs.Save();
	}
	
	void SavePower(int power){
		PlayerPrefs.SetInt(POWER, power);
		PlayerPrefs.Save();
	}
	void SaveStamina(int stamina){
		PlayerPrefs.SetInt(STAMINA, stamina);
		PlayerPrefs.Save();
	}
	void SaveMoney(int money){
		PlayerPrefs.SetInt(MONEY, money);
		PlayerPrefs.Save();
	}
}
