using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnValue : MonoBehaviour {
	public int a, b;
	public float result;

	int Sum(int a, int b){
		int value = a + b;
		return value;
	}

	int Subtract(int a, int b){
		int result = a - b;
		return result;
	}

	float Devide (int a, int b){
		if (b == 0) {
			print ("error, devide by zero");
			return 0;
		} else {
			float val = a / (float) b;
			return val;
		}
	}

	// Use this for initialization
	void Start () {
//		result = Sum (a, b);
//		result = Subtract (result, a);
		result = Devide (a, b);
		print (result);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
