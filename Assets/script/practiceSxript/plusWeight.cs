using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class plusWeight : MonoBehaviour {
	int weight;
	const String WEIGHT = "WEIGHT";

	// Use this for initialization
	void Start () {
		weight = LoadWeight();
		SaveWeight(++weight);
		Debug.Log("up weight:"+weight);
	}

	int LoadWeight(){
		return PlayerPrefs.GetInt(WEIGHT, -1);
	}

	void SaveWeight(int weight){
		PlayerPrefs.SetInt(WEIGHT, weight);
		PlayerPrefs.Save();
	}
}
