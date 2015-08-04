using UnityEngine;
using System;
using System.Collections;
using UnityEngine.UI;
	
public class stratjanken : MonoBehaviour {

	//text create
	public Text timetext,hpText,cpuHpText;

	//GameObj create
	public GameObject startjankenobj,endGameObj,continueObj;

	//hensuu create
	public double gettime,totaltime;	
	public bool flgJanken;

	//teisuu create
	const String WEIGHT = "WEIGHT";
	const String POWER = "POWER";
	const String STAMINA = "STAMINA";
	const String MONEY = "MONEY";
	const String STAGELEVEL = "STAGELEVEL";

	//judge and hand
	const int JANKEN = 0; //constはfinalと一緒
	const int SCISSORS = 1;
	const int STONE = 2;
	const int PAPER = 3;
	const int DRAW = 4;
	const int WIN = 5;
	const int LOOSE = 6;
		
	//myhand
	public int myhand;

	//cpuhand
	public int comhand;

	//get Stage
	public int getStage;

	//myStatus
	int weight;
	int power;
	int stamina;
	int money;
	//cpuStatus
	int cpuWeight;
	int cpuPower;
	int cpuStamina;
	int cpuMoney;
		
	int flgResult; //勝敗結果を保持

	public void Start(){
		flgJanken = true;
		//gameprefsからデータをロード
		stamina = LoadStamina();
		power  = LoadPower();
		weight = LoadWeight();
		money = LoadMoney();
		Debug.Log ("Weight:" + weight);
		Debug.Log ("Stamina:" + stamina);
		Debug.Log ("Power:" + power);
		Debug.Log ("Money:" + money);

		//ステージをロード
		getStage = LoadStageLevel ();



		//敵のステータス取得
		kindRikishi rikishi = new kindRikishi ();
		cpuWeight = rikishi.Weight (getStage);
		cpuPower = rikishi.Power(getStage);
		cpuStamina = rikishi.Stamina (getStage);
		cpuMoney = rikishi.Money (getStage);
		Debug.Log ("cpuWeight:"+cpuWeight);
		Debug.Log ("cpuPower:"+cpuPower);
		Debug.Log ("cpuStamina:"+cpuStamina);
		Debug.Log ("cpuMoney:"+cpuMoney);

		//HP表示
		hpText.text = "自分のHP："+stamina.ToString ();
		cpuHpText.text = "相手のHP："+cpuStamina.ToString ();

		//制限時間を入れる
		totaltime = 10;
	}

	void Update () {
		gettime=Time.deltaTime;
		if (totaltime >= 0) {
			totaltime = totaltime - gettime;
			timetext.text = totaltime.ToString ("N0");
			if(totaltime<=0){
				myhand = STONE;
				judge();
			}
		}

		//
		hpText.text = "自分のHP："+stamina.ToString ();
		cpuHpText.text = "相手のHP："+cpuStamina.ToString ();
		
	}
		
	public void StartJankenbutton(){
		// startjankenが押されたときに動きたい
		flgJanken = true;
	}
		
	//
	public void stonebutton(){

		//ボタンを押した時の音（できれば和風チック）

		if (flgJanken == true) {
			myhand = STONE;
			judge();
		}
	}

	//
	public void paperbutton(){

		//ボタンを押した時の音（できれば和風チック）

		if (flgJanken == true) {
			myhand = PAPER;
			judge();
		}
	}

	//
	public void scissorsbutton(){

		//ボタンを押した時の音（できれば和風チック）

		if (flgJanken == true) {
			myhand = SCISSORS;
			judge();
		}
	}

	//じゃんけんの判定をする
	void judge(){

		comhand = UnityEngine.Random.Range(SCISSORS,PAPER+1);
		//comの手を決める上の場合ランダム
		Debug.Log ("hand:"+myhand);
		Debug.Log ("cpuhand:"+comhand);

		//draw judge
		if(myhand == comhand){
			flgResult = DRAW;
		}else{
			//loose judge
			if(myhand == STONE && comhand == PAPER){
				stamina = stamina - cpuPower;
				if(stamina <= 0){
					flgJanken = false;
					flgResult = LOOSE;
					endGameObj.SetActive(true);
					continueObj.SetActive(true);
				}
				flgResult = LOOSE;
			}else	if(myhand == SCISSORS && comhand == STONE){
				stamina = stamina - cpuPower;
				if(stamina <= 0){
					flgJanken = false;
					flgResult = LOOSE;
					endGameObj.SetActive(true);
					continueObj.SetActive(true);
				}
				flgResult = LOOSE;
			}else	if(myhand == PAPER && comhand == SCISSORS){
				stamina = stamina - cpuPower;
				if(stamina <= 0){
					flgJanken = false;
					flgResult = LOOSE;
					endGameObj.SetActive(true);
					continueObj.SetActive(true);
				}
				flgResult = LOOSE;
			}else{
				//win judge
				//damage
				cpuStamina = cpuStamina - power;
				if(cpuStamina <= 0){
					flgJanken = false;
					endGameObj.SetActive(true);
					flgResult = WIN;
					money = money + cpuMoney;
					SaveMoney(money);
				}
				flgResult = WIN;
			}
		}
		Debug.Log("anser:"+flgResult);
		totaltime = 10;
	}

	//continue
	public void continueButton(){
		flgJanken = true;
		//clickGrowStartButton getStatus = GetComponent<clickGrowStartButton> ();
		//gameprefsからデータをロード
		stamina = LoadStamina();
		power  = LoadPower();
		weight = LoadWeight();
		money = LoadMoney();
		Debug.Log ("Weight:" + weight);
		Debug.Log ("Stamina:" + stamina);
		Debug.Log ("Power:" + power);
		Debug.Log ("Money:" + money);
		
		
		
		//敵のステータス取得
		kindRikishi rikishi = new kindRikishi ();
		cpuWeight = rikishi.Weight (getStage);
		cpuPower = rikishi.Power(getStage);
		cpuStamina = rikishi.Stamina (getStage);
		cpuMoney = rikishi.Money (getStage);
		Debug.Log ("cpuWeight:"+cpuWeight);
		Debug.Log ("cpuPower:"+cpuPower);
		Debug.Log ("cpuStamina:"+cpuStamina);
		Debug.Log ("cpuMoney:"+cpuMoney);
		
		//HP表示
		hpText.text = "自分のHP："+stamina.ToString ();
		cpuHpText.text = "相手のHP："+cpuStamina.ToString ();
		
		//制限時間をいれる
		totaltime = 10;

		endGameObj.SetActive(false);
		continueObj.SetActive(false);
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
	//select Load Stage 
	public int LoadStageLevel(){
		Debug.Log ("Load");
		return PlayerPrefs.GetInt(STAGELEVEL, -1);
	}

	//save
	void SaveMoney(int money){
		PlayerPrefs.SetInt(MONEY, money);
		PlayerPrefs.Save();
	}
}