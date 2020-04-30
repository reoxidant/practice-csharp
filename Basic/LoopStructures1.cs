using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopStructures1 : MonoBehaviour {

	public int age;

	// Use this for initialization
	void Start () {
		while (age < 21) {
//			age = age + 1;
//			age += 1;
			age++;
		}

		do{
			age++;
		}while(age < 21);

//		age = 22
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
