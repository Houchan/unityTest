using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class animeSystem : MonoBehaviour {

	[SerializeField]
	private GameObject Purefabs;

	//アニメーションを流す
	void Start () {
		Instantiate (Purefabs,transform.localPosition, transform.localRotation);
	}
}
