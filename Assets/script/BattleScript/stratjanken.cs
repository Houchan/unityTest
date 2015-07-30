using UnityEngine;
using System.Collections;
using UnityEngine.UI;
	
public class stratjanken : MonoBehaviour {
	public Text timetext;
	public double gettime , totaltime;	
	public bool flgJanken;
	//int modeJanken = 0;　// jankenの状態を管理する

	public GameObject startjankenobj;
		
	const int JANKEN = 0; //constはfinalと一緒
	const int SCISSORS = 1;
	const int STONE = 2;
	const int PAPER = 3;
	const int DRAW = 4;
	const int WIN = 5;
	const int LOOSE = 6;
		
	int myhand;
	int comhand;
		
	int flgResult; //勝敗結果を保持

	public void Start(){
		flgJanken = false;
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
		Debug.Log(flgResult);
	}

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