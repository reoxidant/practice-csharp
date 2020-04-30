using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConditionStatements : MonoBehaviour {

	public int age;
	public bool canBuy;

	// Use this for initialization
	void Start () {
		if (age >= 18) {
			canBuy = true;
		} else if(age < 0){
			age = 0;
			canBuy = false;
		} else {
			canBuy = false;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
