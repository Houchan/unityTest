using UnityEngine;
using System.Collections;

public class mainBgm : MonoBehaviour {

	void Start () {
		SoundManager.Instance.PlayBGM(0);
	}
}
