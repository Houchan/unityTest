using UnityEngine;
using System;
using System.Collections;
using UnityEngine.UI;
	
public class stratjanken : MonoBehaviour {
	public Text timetext,hpText,cpuHpText;
	public double gettime , totaltime;	
	public bool flgJanken;
	//teisuu
	const String WEIGHT = "WEIGHT";
	const String POWER = "POWER";
	const String STAMINA = "STAMINA";
	const String MONEY = "MONEY";

	public GameObject startjankenobj;
		
	const int JANKEN = 0; //constはfinalと一緒
	const int SCISSORS = 1;
	const int STONE = 2;
	const int PAPER = 3;
	const int DRAW = 4;
	const int WIN = 5;
	const int LOOSE = 6;
		
	public int myhand;
	int comhand;
	//myStatus
	int weight;
	int power;
	int stamina;
	int money;
	//
	int cpuWeight;
	int cpuPower;
	int cpuStamina;
	int cpuMoney;
		
	int flgResult; //勝敗結果を保持

	public void Start(){
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



		//
		kindRikishi rikishi = new kindRikishi ();
		cpuWeight = rikishi.Weight ();
		cpuPower = rikishi.Power();
		cpuStamina = rikishi.Stamina ();
		cpuMoney = rikishi.Money ();
		Debug.Log ("cpuWeight:"+cpuWeight);
		Debug.Log ("cpuPower:"+cpuPower);
		Debug.Log ("cpuStamina:"+cpuStamina);
		Debug.Log ("cpuMoney:"+cpuMoney);

		//
		hpText.text = "自分のHP："+stamina.ToString ();
		cpuHpText.text = "相手のHP："+cpuStamina.ToString ();

		//
		totaltime = 10;
	}

	void Update () {
		gettime=Time.deltaTime;
		if (totaltime >= 0) {
			totaltime = totaltime - gettime;
			timetext.text = totaltime.ToString ("N0");
			if(totaltime<=0){
				flgJanken = false;
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
		
	
	public void stonebutton(){
		if (flgJanken == true) {
			myhand = STONE;
			judge();
		}
	}

	
	public void paperbutton(){
		if (flgJanken == true) {
			myhand = PAPER;
			judge();
		}
	}

	
	public void scissorsbutton(){
		if (flgJanken == true) {
			myhand = SCISSORS;
			judge();
		}
	}

	void judge(){
		Debug.Log ("hand:"+myhand);
		comhand = UnityEngine.Random.Range(STONE,PAPER+1);
		//comの手を決める上の場合ランダム
		
		if(myhand == comhand){
			flgResult = DRAW;
		}else{
			switch(comhand){
			case STONE:
				if(myhand == PAPER){
					if(stamina <= 0){
						flgResult = LOOSE;
					}
				}
				break;
				
			case SCISSORS:
				if(myhand == STONE){
					if(stamina <= 0){
						flgResult = LOOSE;
					}
				}
				break;
				
			case PAPER:
				if(myhand == SCISSORS){
					stamina = stamina - cpuPower;
					if(stamina <= 0){
						flgResult = LOOSE;
					}
				}
				break;
			}
			
			if(flgResult != LOOSE){
				cpuStamina = cpuStamina - power;
				if(cpuStamina <= 0){
					flgResult = WIN;
				}
			}
		}

		Debug.Log("anser"+flgResult);
		totaltime = 10;
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
	/*void backButtun(){
	}*/
	/*void Update(){
	if (flgJanken == true) {
		switch (modeJanken) {
		case 0: //じゃんけん開始
			modeJanken++;
			break;

		case 1: //プレイヤー入力待ち
			if(modeJanken == 1){
				//もしぐーボタンが押されたら
				myhand = STONE;
				modeJanken++;

				//もしぱーボタンが押されたら
				myhand = PAPER;
				modeJanken++;

				//もしちょきボタンが押されたら
				myhand = SCISSORS;
				modeJanken++;
			}
			break;

		case 2: //判定
			comhand = Random.Range(STONE,PAPER+1);
			//comの手を決める上の場合ランダム

			if(myhand == comhand){
				flgResult = DRAW;
			}else{
				switch(comhand){
				case STONE:
					if(myhand == PAPER){
						flgResult = LOOSE;
					}
					break;

				case SCISSORS:
					if(myhand == STONE){
						flgResult = LOOSE;
					}
					break;
						
				case PAPER:
					if(myhand == SCISSORS){
						flgResult = LOOSE;
					}
					break;
				}

				if(flgResult != LOOSE){
					flgResult = WIN;
				}
			}
			modeJanken++;
			break;

			case 3: //結果



				modeJanken++;
				break;
			
			case 4: //じゃんけん終了
				flgJanken = false;
				modeJanken = 0;
				break;
			}
		}
	}*/
}