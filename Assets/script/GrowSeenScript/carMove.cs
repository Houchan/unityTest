using UnityEngine;
using System.Collections;

public class carMove : MonoBehaviour {

	private Vector3 car;
	private bool move = true;
	[SerializeField]
	private float speed = 0.3f;

	void Start(){
		SoundManager.Instance.PlaySE(4);
	}

	void Update () {
		car = this.transform.position;
		if (move == true) {
			car.x -= speed;
			this.transform.position = car;
		}
	}

	void OnCollisionEnter(Collision coll){
		if (coll.gameObject.tag == "Player") {
			SoundManager.Instance.PlaySE(5);
			Debug.Log("衝突");
			move = false;
		}
	}

}
