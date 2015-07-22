using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;
using System;
using System.Collections;
using LitJson;

public class clickGrowStartButton : SavableSingleton<clickGrowStartButton>{

	//
	public GameObject growButton,clickStompButton,eatCauldronButton,blockTrackButton,backButtom;
	private int plusstamina, plusweight, plusmusclel;

	public enum ItemNames {
		Hoge,
		Fuga
	}
	
	public string playerName = "";
	public int experience = 0;
	public List<ItemNames> items = new List<ItemNames>();
	
	
	
	//
	public void clickGrowButton(){
		//育成ボタンを押したら各練習のボタンを表示
		growButton.SetActive (false);
		clickStompButton.SetActive(true);
		eatCauldronButton.SetActive(true);
		blockTrackButton.SetActive(true);
	}

	//四股ボタンが押されたら
	public void GrowStompButton(){

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



	public void saveData(){
		clickGrowStartButton.Instance.playerName = "Cat";
		clickGrowStartButton.Instance.experience = 10;
		clickGrowStartButton.Instance.items.Add(clickGrowStartButton.ItemNames.Hoge);
		clickGrowStartButton.Instance.items.Add(clickGrowStartButton.ItemNames.Fuga);
		clickGrowStartButton.Instance.Save();
	}



}