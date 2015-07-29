using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class plusPower : MonoBehaviour {
	int power;
	const String POWER = "POWER";
	
	// Use this for initialization
	void Start () {
		power = LoadPower();
		SavePower(++power);
		Debug.Log("up power:"+power);
	}
	
	int LoadPower(){
		return PlayerPrefs.GetInt(POWER, -1);
	}
	
	void SavePower(int power){
		PlayerPrefs.SetInt(POWER, power);
		PlayerPrefs.Save();
	}
}

