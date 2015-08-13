using UnityEngine;
using System.Collections;

public class backPracticeMenu : MonoBehaviour {

	// Use this for initialization
	public void practiseEndButton(){
		SoundManager.Instance.PlaySE(7);
		Time.timeScale = 1;
		Application.LoadLevel ("practiseSeen");
	}
}
