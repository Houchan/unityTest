using UnityEngine;
using LitJson;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class plusStamina : MonoBehaviour {
	int stamina;
	const String STAMINA = "STAMINA";

	// Use this for initialization
	void Start () {
		stamina = LoadStamina();
		SaveStamina(++stamina);
		Debug.Log("up weight:"+stamina);
	}
	
	int LoadStamina(){
		return PlayerPrefs.GetInt(STAMINA, -1);
	}
	
	void SaveStamina(int stamina){
		PlayerPrefs.SetInt(STAMINA, stamina);
		PlayerPrefs.Save();
	}
}
