using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class clickGrowStartButton : MonoBehaviour {
	//生成するファイル名
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

	//テクストオブジェクトを生成
	public Text staminaText,powerText,weightText,moneyText,moneyJudgeText;

	//ゲームオブジェクトを作成
	public GameObject growButton,clickStompButton,eatCauldronButton,blockTrackButton,backButtom,judgeBox;

	void Start(){
		//gameprefsからデータをロード
		weight = LoadWeight();
		power  = LoadPower();
		stamina = LoadStamina ();
		money = LoadMoney ();

		//最初にゲームを開始する際に初期値を設定
		if (weight == -1) {
			weight =70;
			SaveWeight(weight);
		}
	
		if (power == -1) {
			power = 5;
			SavePower(power);
		}

		if (stamina == -1) {
			stamina = 100;
			SaveStamina(stamina);
		}

		if (money == -1) {
			money = 100;
			SaveMoney(money);
		}

		//ステータスを表示
		weightText.text = "重さ："+weight.ToString ();
		powerText.text = "力："+power.ToString ();
		staminaText.text = "スタミナ："+stamina.ToString ();
		moneyText.text = "所持金："+money.ToString ();

	}

	//クリックボタンが押されたら練習項目のボタンを表示
	public void clickGrowButton(){

		//ボタンを押した時の音（できれば和風チック）

		//育成ボタンを押したら各練習のボタンを表示
		growButton.SetActive (false);
		clickStompButton.SetActive(true);
		eatCauldronButton.SetActive(true);
		blockTrackButton.SetActive(true);
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

	//load
	public int LoadWeight(){
		Debug.Log ("Load");
		return PlayerPrefs.GetInt(WEIGHT, -1);
	}
	public int LoadPower(){
		Debug.Log ("Load");
		return PlayerPrefs.GetInt(POWER, -1);
	}
	public int LoadStamina(){
		Debug.Log ("Load");
		return PlayerPrefs.GetInt(STAMINA, -1);
	}
	public int LoadMoney(){
		Debug.Log ("Load");
		return PlayerPrefs.GetInt(MONEY, -1);
	}

	//四股ボタンが押されたら
	public void GrowStompButton(){

		//ボタンを押した時の音（できれば和風チック）

		if (money >= (100 * stamina) / 10) {
			money = money - (100 * stamina) / 10;
			SaveMoney(money);
			Application.LoadLevel (3);
		} else {
			judgeBox.SetActive(true);
		}
	}

	//トラックを止めるボタンが押されたら
	public void GrowStopTrackButton(){

		//ボタンを押した時の音（できれば和風チック）

		if(money >= (100 * power)/10){
			money = money - (100 * power)/10;
			SaveMoney(money);
			Application.LoadLevel (2);
		} else {
			judgeBox.SetActive(true);
		}
	}

	//ちゃんこ鍋ボタンが押されたら
	public void GrowEatChankonabe(){

		//ボタンを押した時の音（できれば和風チック）

		if(money >= (100 * weight)/10){
			money = money - (100 * weight)/10;
			SaveMoney(money);
			Application.LoadLevel (1);
		} else {
			judgeBox.SetActive(true);
		}

	}
	
	//ホーム画面に戻る
	public void backHomeButton(){

		//ボタンを押した時の音（できれば和風チック）

		SaveWeight(weight);
		SavePower(power);
		SaveStamina(stamina);
		SaveMoney(money);
		Application.LoadLevel ("gameMainSeen");
	}
	
	//練習画面に戻る
	public void backMenuButton(){
		growButton.SetActive (true);
		clickStompButton.SetActive(false);
		eatCauldronButton.SetActive(false);
		blockTrackButton.SetActive(false);
		judgeBox.SetActive(false);
	}

	//データを全部初期化
	public void deleteAllButton(){
		PlayerPrefs.DeleteAll ();
		Debug.Log ("Delete complete");
	}

}