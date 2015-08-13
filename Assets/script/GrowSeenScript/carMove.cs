using UnityEngine;
using System.Collections;

public class carMove : MonoBehaviour {

	private Vector3 car;
	private bool move = true;

	void Update () {
		car = this.transform.position;
		if (move == true) {
			car.x -= 0.1f;
			this.transform.position = car;
		}
	}

	void OnCollisionEnter(Collision coll){
		if (coll.gameObject.tag == "Player") {
			Debug.Log("衝突");
			move = false;
		}
	}

}
