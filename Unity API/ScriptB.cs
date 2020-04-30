using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptB : MonoBehaviour {

	public ScriptA scriptA;

	// Use this for initialization
	void Start () {
//		if (GetComponent<ScriptA> () != null) {
//			GetComponent<ScriptA> ().text = "Hello World From Script B";
//		} else {
//			print ("There is not such component");
//		}

//		GameObject.FindObjectOfType<ScriptA>().text = "GameObject Hello Form ScriptB";

//		scriptA.text = "Instance Hello from ScriptB";

//		scriptA.Hello ();

		scriptA.text = scriptA.Hello ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
