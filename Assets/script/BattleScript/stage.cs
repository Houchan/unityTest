using UnityEngine;
using System;
using System.Collections;
using UnityEngine.UI;

public class stage : MonoBehaviour {

	SpriteRenderer MainSpriteRenderer;
	[SerializeField]
	private Sprite[] stageImage;
	public int getStage;
	const String STAGELEVEL = "STAGELEVEL";

	//SpriteRendererを取得
	void Awake(){
		MainSpriteRenderer = gameObject.GetComponent<SpriteRenderer>();
		getStage = LoadStageLevel ();
	}

	//場所別に画像を設定
	void Start () {
		MainSpriteRenderer.sprite = stageImage[getStage-1];
	}

	public int LoadStageLevel(){
		return PlayerPrefs.GetInt(STAGELEVEL, -1);
	}
}