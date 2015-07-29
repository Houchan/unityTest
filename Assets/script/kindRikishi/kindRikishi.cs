using UnityEngine;
using System.Collections;

public class kindRikishi : Rikishi {

}

public class player1:Rikishi{
	public string Name(){
		return "大山田";
	}

	public int Weight(){
		return 80;
	}

	public int Stamina(){
		return 150;
	}

	public int Power(){
		return 30;
	}

	public int Money(){
		return 1000;
	}
}