using UnityEngine;
using System.Collections;

public class kindRikishi : Rikishi {


	public new string Name(int patternRikishi){
		if (patternRikishi == 1) {
			return "大山田";
		}
		if (patternRikishi == 2) {
			return "朝叉焼";
		}
		if (patternRikishi == 3) {
			return "白桃";
		}
		if (patternRikishi == 4) {
			return "暗石志賀之神";
		}
		return "imasenn";
	}
	
	public new int Weight(int patternRikishi){
		if (patternRikishi == 1) {
			return 80;
		}
		if (patternRikishi == 2) {
			return 100;
		}
		if (patternRikishi == 3) {
			return 150;
		}
		if (patternRikishi == 4) {
			return 200;
		}
		return 0;
	}
	
	public new int Stamina(int patternRikishi){
		if (patternRikishi == 1) {
			return 150;
		}
		if (patternRikishi == 2) {
			return 300;
		}
		if (patternRikishi == 3) {
			return 500;
		}
		if (patternRikishi == 4) {
			return 1000;
		}
		return 0;
	}
	
	public new int Power(int patternRikishi){
		if (patternRikishi == 1) {
			return 30;
		}
		if (patternRikishi == 2) {
			return 60;
		}
		if (patternRikishi == 3) {
			return 75;
		}
		if (patternRikishi == 4) {
			return 150;
		}
		return 0;
	}
	
	public new int Money(int patternRikishi){
		if(patternRikishi == 1){
			return 1000;
		}
		if(patternRikishi == 2){
			return 5000;
		}
		if(patternRikishi == 3){
			return 10000;
		}
		if(patternRikishi == 4){
			return 50000;
		}
		return 0;
	}

}

