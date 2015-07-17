using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class clickGrowStartButton : MonoBehaviour{
	//
	public GameObject growButton,clickStompButton,eatCauldronButton,blockTrackButton,backButtom;
	public int plusstamina, plusweight, plusmusclel;


	//
	public void clickGrowButton(){
		//育成ボタンを押したら各練習のボタンを表示
		growButton.SetActive (false);
		clickStompButton.SetActive(true);
		eatCauldronButton.SetActive(true);
		blockTrackButton.SetActive(true);
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
}
