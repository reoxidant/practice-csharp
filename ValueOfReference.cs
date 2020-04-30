using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ValueOfReference : MonoBehaviour {


	public int integer;
	public float[] arrayOfValues;

	// Use this for initialization
	void Start () {
		DoSomething (ref integer);
		DoSomething (arrayOfValues);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	// передача по значению
	void DoSomething(ref int b){
		b += 3;
	}

	// передача по ссылке
	void DoSomething(float[] array){
		array [0] = 3.4f;
	}

}
