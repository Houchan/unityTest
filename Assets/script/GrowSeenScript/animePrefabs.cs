using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class animePrefabs : MonoBehaviour {

	private float time = 0.0f;
	[SerializeField]
	private int endTime = 2;
	[SerializeField]
	private GameObject endButton;
	private bool flg = false;
	
	void Update(){
		time += Time.deltaTime;
		if (time >= endTime && (flg == false)) {
			Time.timeScale = 0;	//アニメ停止
			SoundManager.Instance.PlaySE(1);
			endButton.SetActive(true);//終了ボタン表示
			flg = true;
		}
	}
}
