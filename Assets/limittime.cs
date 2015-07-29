using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class limittime : MonoBehaviour {
	public Text timetext;
	public double gettime , totaltime;
	// Use this for initialization
	void Start () {
		totaltime = 10;
	
	}
	
	// Update is called once per frame
	void Update () {
		gettime=Time.deltaTime;
		if (totaltime >= 0) {
			totaltime = totaltime - gettime;
			timetext.text = totaltime.ToString ("N0");
		}

	}
}
