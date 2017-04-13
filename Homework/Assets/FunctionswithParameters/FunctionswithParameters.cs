using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FunctionswithParameters : MonoBehaviour {

public int health = 100;
public int gameBonus = 0;
public int maxBonus = 100;

	// Use this for initialization
	void Start () {
		maxBonus = DoubleMaxBonus(maxBonus);
		print(maxBonus);
	}	
	int MultiplyHealth (int health) {
		int ret;
		ret = health * 2;
		return ret;
	}
	int AddHealth (int health) {
		int healthboost;
		healthboost = health + 5;
		return healthboost;
	}
	int SubtractHealth (int health) {
		int hit;
		hit = health - 17;
		return hit;
	}
	int GameOver (int health) {
		int KO;
		KO = health - health;
		return KO;
	}
	int SmallBonus (int gameBonus) {
		int small;
		small = gameBonus + 1;
		return small;
	}
	int NoBonus (int gameBonus) {
		int none;
		none = gameBonus + 0;
		return none;
	}
	int MediumBonus (int gameBonus) {
		int medium;
		medium = gameBonus + 25;
		return medium;
	}
	int LargeBonus (int gameBonus) {
		int large;
		large = gameBonus + 75;
		return large;
	}
	int MaxBonus (int gameBonus) {
		int max;
		max = gameBonus + 100;
		return max;
	}
	int DoubleMaxBonus (int maxBonus) {
		int absolute;
		absolute = maxBonus * 2;
		return absolute;
		
	}
}