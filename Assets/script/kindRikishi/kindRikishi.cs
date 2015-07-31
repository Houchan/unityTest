using UnityEngine;
using System.Collections;

public class kindRikishi : Rikishi {
	public new string Name(){
		return "大山田";
	}
	
	public new int Weight(){
		return 80;
	}
	
	public new int Stamina(){
		return 150;
	}
	
	public new int Power(){
		return 30;
	}
	
	public new int Money(){
		return 1000;
	}

}

public class player1:Rikishi{
	public new string Name(){
		return "大山田";
	}

	public new int Weight(){
		return 80;
	}

	public new int Stamina(){
		return 150;
	}

	public new int Power(){
		return 30;
	}

	public new int Money(){
		return 1000;
	}
}