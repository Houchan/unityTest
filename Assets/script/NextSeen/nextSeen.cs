﻿using UnityEngine;
using System;
using System.Collections;

public class nextSeen : MonoBehaviour {
	//teisuu
	const String STAGELEVEL = "STAGELEVEL";

	// Update is called once per frame
	void Update () {
	
	}

	//ボタンを押した時の音（できれば和風チック）
	//save,loadメソッド以外のメソッドに音を追加

	//稽古ボタンが押されたら稽古シーンに繊維
	public void nextPracticeSeen(){
		SoundManager.Instance.PlaySE(6);
		Application.LoadLevel ("practiseSeen");
	}

	//初場所ボタンが押されたら初場所ステージに繊維
	public void nextFirstStageSeen(){
		SoundManager.Instance.PlaySE(6);
		SoundManager.Instance.StopBGM();
		SaveStageLevel (1);
		Application.LoadLevel ("janken");
	}
	//夏場所ボタンが押されたら夏場所ステージに繊維
	public void nextSecondStageSeen(){
		SoundManager.Instance.PlaySE(6);
		SoundManager.Instance.StopBGM();
		SaveStageLevel (2);
		Application.LoadLevel ("janken");
	}
	//月面ボタンが押されたら月面ステージに繊維
	public void nextThirdStageSeen(){
		SoundManager.Instance.PlaySE(6);
		SoundManager.Instance.StopBGM();
		SaveStageLevel (3);
		Application.LoadLevel ("janken");
	}
	//太陽ボタンが押されたら太陽ステージに繊維
	public void nextForceStageSeen(){
		SoundManager.Instance.PlaySE(6);
		SoundManager.Instance.StopBGM();
		SaveStageLevel (4);
		Application.LoadLevel ("janken");
	}
	//試合ボタンが押されたら試合場所選択シーンに繊維
	public void nextSelectStageSeen(){
		SoundManager.Instance.PlaySE(6);
		Application.LoadLevel ("selectSeen");
	}
	//メニューに戻るボタンが押されたらゲームメインシーンに繊維
	public void backMenuSeen(){
		SoundManager.Instance.PlaySE(6);
		Application.LoadLevel ("gameMainSeen");
	}

	//load
	public int LoadStageLevel(){
		Debug.Log ("Load");
		return PlayerPrefs.GetInt(STAGELEVEL, -1);
	}
	
	//save
	void SaveStageLevel(int stageLevel){
		PlayerPrefs.SetInt(STAGELEVEL, stageLevel);
		PlayerPrefs.Save();
	}
}
