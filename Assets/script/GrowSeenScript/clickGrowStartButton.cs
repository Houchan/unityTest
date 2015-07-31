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
	public Text staminaText,powerText,weightText,moneyText;

	//ゲームオブジェクトを作成
	public GameObject growButton,clickStompButton,eatCauldronButton,blockTrackButton,backButtom;

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
			stamina =10;
			SaveStamina(stamina);
		}

		if (money == -1) {
			money = 100;
			SaveMoney(money);
		}

		/*try{
			power = LoadPower();
			Debug.Log ("load power:"+power);
			
		}catch(NullReferenceException){
			power = 5;
			
		}

		try{
			stamina = LoadStamina();
			Debug.Log ("load stamina:"+stamina);

		}catch(NullReferenceException){
			stamina = 3;
			
		}

		try{
			money = LoadMoney();
			Debug.Log ("load money:"+money);
			
		}catch(NullReferenceException){
			money = 1;

		}*/

		//ステータスを表示
		weightText.text = "重さ："+weight.ToString ();
		powerText.text = "力："+power.ToString ();
		staminaText.text = "スタミナ："+stamina.ToString ();
		moneyText.text = "所持金："+money.ToString ();

	}


	public void clickGrowButton(){

		//育成ボタンを押したら各練習のボタンを表示
		growButton.SetActive (false);
		clickStompButton.SetActive(true);
		eatCauldronButton.SetActive(true);
		blockTrackButton.SetActive(true);
		
		//CHECK

		/*SavePower(++power);
		power = LoadPower ();
		Debug.Log("up power:"+power);

		SaveStamina(++stamina);
		stamina = LoadStamina ();
		Debug.Log("up stamina:"+stamina);


		SaveMoney(++money);
		money = LoadMoney ();
		Debug.Log("up money:"+money);
		*/
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
		Application.LoadLevel (3);
	}

	//トラックを止めるボタンが押されたら
	public void GrowStopTrackButton(){
		Application.LoadLevel (2);
	}

	//ちゃんこ鍋ボタンが押されたら
	public void GrowEatChankonabe(){
		Application.LoadLevel (1);
	}
	
	//ホーム画面に戻る
	public void backHomeButton(){
		
	}
	
	//練習画面に戻る
	public void backMenuButton(){
		growButton.SetActive (true);
		clickStompButton.SetActive(false);
		eatCauldronButton.SetActive(false);
		blockTrackButton.SetActive(false);
	}

	//データを全部初期化
	public void deleteAllButton(){
		PlayerPrefs.DeleteAll ();
		Debug.Log ("Delete complete");
	}

	/*void Start () {
		TextAsset json = Resources.Load("JSON/Sample") as TextAsset;
		Person person = JsonMapper.ToObject<Person>(json.text);
		person.power++;
		Debug.Log(person.name);
		Debug.Log(person.power);
		Debug.Log(person.weight);
		Debug.Log(person.stamina);
	}*/

}
/*
public class Person {
	public string name;
	public int power;
	public double weight;
	public int stamina;
}

public class Save{
}
*/