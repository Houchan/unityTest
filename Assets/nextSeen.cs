using UnityEngine;
using System.Collections;

public class nextSeen : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void nextGameMainSeen(){
		Application.LoadLevel (5);
	}

	public void nextPracticeSeen(){
		Application.LoadLevel (0);

	}

}
