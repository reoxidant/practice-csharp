using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Functions : MonoBehaviour {

	public string myText;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		SayHello ();
		SaySomething (myText);
	}

	void SayHello() {
		print ("Hello");
	}

	void SaySomething(string something){
		print (something);
	}
}
