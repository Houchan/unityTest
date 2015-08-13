using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class animePrefabs : MonoBehaviour {
	private float time = 0.0f;

	//　アニメの終了
	void Update(){
		time += Time.deltaTime;
		if (time >= 2) {
			Time.timeScale = 0;
		}
	}
}
